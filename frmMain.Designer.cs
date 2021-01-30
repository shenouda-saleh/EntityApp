
namespace EntityApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGetTables = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clbTables = new System.Windows.Forms.CheckedListBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExportClasses = new System.Windows.Forms.Button();
            this.txtSql = new System.Windows.Forms.RichTextBox();
            this.txtCS = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExportSql = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.savefile = new System.Windows.Forms.SaveFileDialog();
            this.saveFileCS = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.35362F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.5075718F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.74617F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.39264F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnGetTables, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnGenerate, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.203681F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.174222F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.14063F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.481462F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(156, 444);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnGetTables
            // 
            this.btnGetTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGetTables.Location = new System.Drawing.Point(3, 39);
            this.btnGetTables.Name = "btnGetTables";
            this.btnGetTables.Size = new System.Drawing.Size(150, 25);
            this.btnGetTables.TabIndex = 1;
            this.btnGetTables.Text = "Get Tables";
            this.btnGetTables.UseVisualStyleBackColor = true;
            this.btnGetTables.Click += new System.EventHandler(this.btnGetTables_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtConnectionString);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 30);
            this.panel1.TabIndex = 0;
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConnectionString.Location = new System.Drawing.Point(0, 0);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(150, 26);
            this.txtConnectionString.TabIndex = 0;
            this.txtConnectionString.Text = "Connection String Path";
            this.txtConnectionString.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConnectionString.Click += new System.EventHandler(this.txtConnectionString_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.clbTables);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 340);
            this.panel2.TabIndex = 1;
            // 
            // clbTables
            // 
            this.clbTables.CheckOnClick = true;
            this.clbTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbTables.FormattingEnabled = true;
            this.clbTables.Location = new System.Drawing.Point(0, 0);
            this.clbTables.Name = "clbTables";
            this.clbTables.Size = new System.Drawing.Size(150, 340);
            this.clbTables.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerate.Location = new System.Drawing.Point(3, 416);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(150, 25);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.txtSql, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(169, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(311, 444);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnExportClasses
            // 
            this.btnExportClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExportClasses.Location = new System.Drawing.Point(3, 415);
            this.btnExportClasses.Name = "btnExportClasses";
            this.btnExportClasses.Size = new System.Drawing.Size(305, 26);
            this.btnExportClasses.TabIndex = 4;
            this.btnExportClasses.Text = "Export Tables to Classes";
            this.btnExportClasses.UseVisualStyleBackColor = true;
            this.btnExportClasses.Click += new System.EventHandler(this.btnExportClasses_Click);
            // 
            // txtSql
            // 
            this.txtSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSql.Location = new System.Drawing.Point(3, 3);
            this.txtSql.Name = "txtSql";
            this.txtSql.Size = new System.Drawing.Size(305, 406);
            this.txtSql.TabIndex = 0;
            this.txtSql.Text = "";
            // 
            // txtCS
            // 
            this.txtCS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCS.Location = new System.Drawing.Point(3, 3);
            this.txtCS.Name = "txtCS";
            this.txtCS.Size = new System.Drawing.Size(305, 406);
            this.txtCS.TabIndex = 1;
            this.txtCS.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExportSql);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 415);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 26);
            this.panel3.TabIndex = 2;
            // 
            // btnExportSql
            // 
            this.btnExportSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExportSql.Location = new System.Drawing.Point(0, 0);
            this.btnExportSql.Name = "btnExportSql";
            this.btnExportSql.Size = new System.Drawing.Size(305, 26);
            this.btnExportSql.TabIndex = 3;
            this.btnExportSql.Text = "Export StoredProced";
            this.btnExportSql.UseVisualStyleBackColor = true;
            this.btnExportSql.Click += new System.EventHandler(this.btnExportSql_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.btnExportClasses, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtCS, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(486, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(311, 444);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // savefile
            // 
            this.savefile.DefaultExt = "sql";
            this.savefile.Filter = "Text files (*.sql)|*.sql|All files (*.*)|*.*";
            this.savefile.FileOk += new System.ComponentModel.CancelEventHandler(this.savefile_FileOk);
            // 
            // saveFileCS
            // 
            this.saveFileCS.DefaultExt = "cs";
            this.saveFileCS.Filter = "Text files (*.cs)|*.cs|All files (*.*)|*.*";
            this.saveFileCS.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileCS_FileOk);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Name = "frmMain";
            this.Text = "Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGetTables;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox clbTables;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnExportClasses;
        private System.Windows.Forms.RichTextBox txtSql;
        private System.Windows.Forms.RichTextBox txtCS;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExportSql;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.SaveFileDialog savefile;
        private System.Windows.Forms.SaveFileDialog saveFileCS;
    }
}

