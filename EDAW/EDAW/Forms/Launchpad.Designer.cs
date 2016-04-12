namespace EDAW
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgvExplorers = new System.Windows.Forms.DataGridView();
            this.colOccupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobLvl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJobLvlOthr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEducationOthr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGener = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.personalSurveyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employerSurveyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExport = new System.Windows.Forms.Button();
            this.grpExport = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExplorers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.grpExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExplorers
            // 
            this.dgvExplorers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExplorers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOccupation,
            this.colJobLvl,
            this.colJobLvlOthr,
            this.colExpert,
            this.colEducation,
            this.colEducationOthr,
            this.colGener});
            this.dgvExplorers.Location = new System.Drawing.Point(453, 12);
            this.dgvExplorers.Name = "dgvExplorers";
            this.dgvExplorers.Size = new System.Drawing.Size(761, 591);
            this.dgvExplorers.TabIndex = 0;
            this.dgvExplorers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExplorers_CellClick);
            this.dgvExplorers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvExplorers_MouseClick_1);
            // 
            // colOccupation
            // 
            this.colOccupation.HeaderText = "Occupation";
            this.colOccupation.Name = "colOccupation";
            this.colOccupation.ReadOnly = true;
            // 
            // colJobLvl
            // 
            this.colJobLvl.HeaderText = "Job Level";
            this.colJobLvl.Name = "colJobLvl";
            this.colJobLvl.ReadOnly = true;
            // 
            // colJobLvlOthr
            // 
            this.colJobLvlOthr.HeaderText = "Job Level Other";
            this.colJobLvlOthr.Name = "colJobLvlOthr";
            this.colJobLvlOthr.ReadOnly = true;
            // 
            // colExpert
            // 
            this.colExpert.HeaderText = "Expertise";
            this.colExpert.Name = "colExpert";
            this.colExpert.ReadOnly = true;
            // 
            // colEducation
            // 
            this.colEducation.HeaderText = "Education";
            this.colEducation.Name = "colEducation";
            this.colEducation.ReadOnly = true;
            // 
            // colEducationOthr
            // 
            this.colEducationOthr.HeaderText = "Education Other";
            this.colEducationOthr.Name = "colEducationOthr";
            this.colEducationOthr.ReadOnly = true;
            // 
            // colGener
            // 
            this.colGener.HeaderText = "Gender";
            this.colGener.Name = "colGener";
            this.colGener.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalSurveyToolStripMenuItem,
            this.employerSurveyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 48);
            // 
            // personalSurveyToolStripMenuItem
            // 
            this.personalSurveyToolStripMenuItem.Name = "personalSurveyToolStripMenuItem";
            this.personalSurveyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.personalSurveyToolStripMenuItem.Text = "Personal Survey";
            this.personalSurveyToolStripMenuItem.Click += new System.EventHandler(this.personalSurveyToolStripMenuItem_Click);
            // 
            // employerSurveyToolStripMenuItem
            // 
            this.employerSurveyToolStripMenuItem.Name = "employerSurveyToolStripMenuItem";
            this.employerSurveyToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.employerSurveyToolStripMenuItem.Text = "Employer Survey";
            this.employerSurveyToolStripMenuItem.Click += new System.EventHandler(this.employerSurveyToolStripMenuItem_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(19, 19);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // grpExport
            // 
            this.grpExport.Controls.Add(this.btnExport);
            this.grpExport.Location = new System.Drawing.Point(312, 46);
            this.grpExport.Name = "grpExport";
            this.grpExport.Size = new System.Drawing.Size(124, 56);
            this.grpExport.TabIndex = 2;
            this.grpExport.TabStop = false;
            this.grpExport.Text = "Export Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 615);
            this.Controls.Add(this.grpExport);
            this.Controls.Add(this.dgvExplorers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExplorers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.grpExport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExplorers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personalSurveyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employerSurveyToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOccupation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobLvl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJobLvlOthr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpert;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEducation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEducationOthr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGener;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox grpExport;
    }
}

