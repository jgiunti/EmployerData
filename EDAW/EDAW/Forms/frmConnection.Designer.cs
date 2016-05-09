namespace EDAW.Forms
{
    partial class frmConnection
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.colConn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblConn = new System.Windows.Forms.Label();
            this.btnCurrConn = new System.Windows.Forms.Label();
            this.lblDb = new System.Windows.Forms.Label();
            this.lvDb = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colConn});
            this.listView1.Location = new System.Drawing.Point(293, 33);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(243, 92);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colConn
            // 
            this.colConn.Text = "Connection";
            this.colConn.Width = 254;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 59);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblConn
            // 
            this.lblConn.AutoSize = true;
            this.lblConn.Location = new System.Drawing.Point(12, 14);
            this.lblConn.Name = "lblConn";
            this.lblConn.Size = new System.Drawing.Size(91, 13);
            this.lblConn.TabIndex = 3;
            this.lblConn.Text = "Connection String";
            // 
            // btnCurrConn
            // 
            this.btnCurrConn.AutoSize = true;
            this.btnCurrConn.Location = new System.Drawing.Point(290, 17);
            this.btnCurrConn.Name = "btnCurrConn";
            this.btnCurrConn.Size = new System.Drawing.Size(98, 13);
            this.btnCurrConn.TabIndex = 4;
            this.btnCurrConn.Text = "Current Connection";
            // 
            // lblDb
            // 
            this.lblDb.AutoSize = true;
            this.lblDb.Location = new System.Drawing.Point(290, 170);
            this.lblDb.Name = "lblDb";
            this.lblDb.Size = new System.Drawing.Size(90, 13);
            this.lblDb.TabIndex = 6;
            this.lblDb.Text = "Current Database";
            // 
            // lvDb
            // 
            this.lvDb.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvDb.Location = new System.Drawing.Point(293, 186);
            this.lvDb.MultiSelect = false;
            this.lvDb.Name = "lvDb";
            this.lvDb.Size = new System.Drawing.Size(243, 92);
            this.lvDb.TabIndex = 5;
            this.lvDb.UseCompatibleStateImageBehavior = false;
            this.lvDb.View = System.Windows.Forms.View.List;
            this.lvDb.SelectedIndexChanged += new System.EventHandler(this.lvDb_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Database";
            this.columnHeader1.Width = 254;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Database Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDb
            // 
            this.txtDb.Location = new System.Drawing.Point(12, 186);
            this.txtDb.Name = "txtDb";
            this.txtDb.Size = new System.Drawing.Size(213, 20);
            this.txtDb.TabIndex = 7;
            // 
            // frmConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 306);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDb);
            this.Controls.Add(this.lblDb);
            this.Controls.Add(this.lvDb);
            this.Controls.Add(this.btnCurrConn);
            this.Controls.Add(this.lblConn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Name = "frmConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmConnection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblConn;
        private System.Windows.Forms.Label btnCurrConn;
        private System.Windows.Forms.ColumnHeader colConn;
        private System.Windows.Forms.Label lblDb;
        private System.Windows.Forms.ListView lvDb;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDb;
    }
}