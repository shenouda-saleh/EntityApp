using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityApp
{
    public partial class frmMain : Form
    {
        WorkTable workTable = new WorkTable();
        DataTable tblTables = new DataTable();
        DataTable tblColumns = new DataTable();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtConnectionString.Text = "Data Source=.;Initial Catalog=DBEmployee;Integrated Security=True";
        }

        private void btnGetTables_Click(object sender, EventArgs e)
        {
            clbTables.Items.Clear();
            workTable.ConStr = txtConnectionString.Text;
            tblTables = workTable.RunQuery("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES");
            for (int i = 0; i < tblTables.Rows.Count; i++)
                clbTables.Items.Add(tblTables.Rows[i][0].ToString());

        }

        private void txtConnectionString_Click(object sender, EventArgs e)
        {
            txtConnectionString.Text = "";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string where = "WHERE";
            for (int i = 0; i < clbTables.CheckedItems.Count; i++)
                where += " TABLE_NAME = '" + clbTables.CheckedItems[i].ToString() + "' OR ";

            where = where.Remove(where.Length - 4, 4);
            string query = $@"SELECT TABLE_NAME,COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,
                                           NUMERIC_SCALE,IS_NULLABLE FROM INFORMATION_SCHEMA.COLUMNS " + where;
            tblColumns = workTable.RunQuery(query);
            generateSql(tblColumns);
        }

        private void generateSql(DataTable table)
        {
            string allProcedure = "";
            string allClasses = "";
            for (int i = 0; i < clbTables.CheckedItems.Count; i++)
            {
                string table_name = clbTables.CheckedItems[i].ToString();
                DataTable dataTable = new DataTable();
                dataTable = table.Select("TABLE_NAME='" + table_name + "'").CopyToDataTable();
                string proced_column = "";
                string update_stmt = "";
                string Insert_stmt = "";
                string variableclass = "";
                string table_PK = workTable.getPrimaryKey(table_name);
                string PK_Datatype = dataType(dataTable.Select("COLUMN_NAME='" + table_PK + "'").CopyToDataTable().Rows[0]).Rows[0][0].ToString();

                for (int x = 0; x < dataTable.Rows.Count; x++)
                {
                    proced_column += "\n\t@" + dataTable.Rows[x]["COLUMN_NAME"].ToString() + " " + dataType(dataTable.Rows[x]).Rows[0][1].ToString() + ",";
                    update_stmt += $@"{dataTable.Rows[x]["COLUMN_NAME"].ToString()}=@{dataTable.Rows[x]["COLUMN_NAME"].ToString() },";
                    variableclass += "\n\tpublic " + dataType(dataTable.Rows[x]).Rows[0][0].ToString() + "  " + dataTable.Rows[x]["COLUMN_NAME"].ToString() + "  { get; set; }";
                    Insert_stmt += "@" + dataTable.Rows[x]["COLUMN_NAME"].ToString() + ",";
                }

                proced_column = proced_column.Remove(proced_column.Length - 1, 1);
                update_stmt = update_stmt.Remove(update_stmt.Length - 1, 1);
                Insert_stmt = Insert_stmt.Remove(Insert_stmt.Length - 1, 1);

                allProcedure += concatStringProcedure(table_name, table_PK, proced_column, update_stmt, PK_Datatype, Insert_stmt);
                allClasses += concatStringClass(variableclass, table_name);
            }
            txtSql.Text = allProcedure;
            txtCS.Text = allClasses;

        }



        private DataTable dataType(DataRow dataRow)
        {
            string _datatype = dataRow["DATA_TYPE"].ToString();
            string _CHARACTER_MAXIMUM_LENGTH = dataRow["CHARACTER_MAXIMUM_LENGTH"].ToString();
            string _NUMERIC_PRECISION = dataRow["NUMERIC_PRECISION"].ToString();
            string _NUMERIC_SCALE = dataRow["NUMERIC_SCALE"].ToString();
            DataTable datatype = new DataTable();
            datatype.Columns.Add("typeofclass");
            datatype.Columns.Add("typeofprocedure");
            if (_datatype == "nvarchar")
            {
                if (int.Parse(_CHARACTER_MAXIMUM_LENGTH) == -1)
                    datatype.Rows.Add("string", $@"nvarchar(MAX)");
                else
                    datatype.Rows.Add("string", $@"nvarchar({_CHARACTER_MAXIMUM_LENGTH})");
            }
            else if (_datatype == "int")
                datatype.Rows.Add("int", "int");
            else if (_datatype == "numeric")
                datatype.Rows.Add("decimal", $@"numeric({_NUMERIC_PRECISION},{_NUMERIC_SCALE})");
            else if (_datatype == "decimal")
                datatype.Rows.Add("decimal", $@"decimal({_NUMERIC_PRECISION},{_NUMERIC_SCALE})");
            else if (_datatype == "date")
                datatype.Rows.Add("DateTime", "date");
            else if (_datatype == "nchar")
                datatype.Rows.Add("string", $@"nchar({_CHARACTER_MAXIMUM_LENGTH})");

            return datatype;
        }

        private string concatStringProcedure(string table_name, string table_PK, string proced_column, string update_stmt, string PK_Datatype,string Insert_stmt)
        {
            string removecolumnidentity = workTable.identity_columns(table_name) == true ? proced_column.Remove(0, ("\n\t@" + table_PK + " " + PK_Datatype + ",").Length) : proced_column;
            string _removecolumnidentity = workTable.identity_columns(table_name) == true ? proced_column.Remove(0, ("\n\t@" + table_PK + ",").Length) : Insert_stmt;

            return $@"
CREATE PROCEDURE  Add_{ table_name} 
                {removecolumnidentity}
 AS
BEGIN 
               insert into {table_name} values({Insert_stmt.Replace("\n", "").Replace("\t", "") } )
END
GO


CREATE PROCEDURE  Update_{table_name}
                {proced_column } 
AS
BEGIN
                update {table_name} set {update_stmt} Where {table_PK}=@{table_PK }
END
GO


CREATE PROCEDURE  Delete_{table_name}
               @{table_PK + " " + PK_Datatype}
AS
BEGIN
                Delete from {table_name} Where  {table_PK}=@{table_PK }
END
GO

/*=============================End Create Stored Procedures For Table {table_name}==================================*/

 ";
        }
        private string concatStringClass(string prop, string table_name)
        {
            return "using System;\n using System.Collections.Generic;\n using System.Linq;\n using System.Web;\n\n\n public class " + table_name + "{\n" +
                       prop + "  \n\n\tpublic " + table_name + "(){}\n\n}\n\n" +
                       "/*===============End Class " + table_name + "=======================*/\n\n";
        }

        private void savefile_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(savefile.FileName, txtSql.Text);
        }

        private void saveFileCS_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(saveFileCS.FileName, txtCS.Text);
        }

        private void btnExportSql_Click(object sender, EventArgs e)
        {
            savefile.ShowDialog();
        }

        private void btnExportClasses_Click(object sender, EventArgs e)
        {
            saveFileCS.ShowDialog();
        }

    }
}
