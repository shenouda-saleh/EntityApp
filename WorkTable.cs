using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace EntityApp
{
    class WorkTable
    {
        SqlConnection con;
        SqlCommand cmd;
        DataTable tbl;
        internal int ErrorCode;
        public string ConStr = "";

        private void Connect()
        {
            con = new SqlConnection(ConStr);
            if (con.State == ConnectionState.Closed)
                con.Open();
        }

        private void DisConnect()
        {
            con = new SqlConnection(ConStr);
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        public string RunDml(string Stmt)
        {
            try
            {
                Connect();
                cmd = new SqlCommand(Stmt, con);
                cmd.ExecuteNonQuery();
                return "ok";
            }
            catch (SqlException ex)
            {
                ErrorCode = ex.ErrorCode;
                return ex.Message;
            }
            finally
            {
                DisConnect();
            }
        }

        public DataTable RunQuery(string Query)
        {
            try
            {
                tbl = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(Query, ConStr);
                adapter.Fill(tbl);
                return tbl;
            }
            catch (SqlException ex)
            {
                ErrorCode = ex.ErrorCode;
                return null;
            }
        }

        public string getPrimaryKey(string table_name)
        {
            DataTable tblpk = new DataTable();
            tblpk = RunQuery("select pk.[name] as pk_name,col.[name] as column_name,tab.[name] as table_name from sys.tables tab " +
                                        "inner join sys.indexes pk on tab.object_id = pk.object_id and pk.is_primary_key = 1 " +
                                        "inner join sys.index_columns ic on ic.object_id = pk.object_id and ic.index_id = pk.index_id " +
                                        "inner join sys.columns col on pk.object_id = col.object_id and col.column_id = ic.column_id " +
                                        "where tab.name='" + table_name + "'");

            return tblpk.Rows[0]["column_name"].ToString();
        }

        public bool identity_columns(string table_name)
        {
            DataTable tblpk = new DataTable();
            tblpk = RunQuery("SELECT * FROM sys.identity_columns WHERE OBJECT_NAME(object_id) = '" + table_name+"'");
            if (tblpk.Rows.Count >0)
                return true;

            return false;
        }

    }

}

