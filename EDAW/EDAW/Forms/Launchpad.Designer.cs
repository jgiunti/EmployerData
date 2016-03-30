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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.personalSurveyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employerSurveyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExplorers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExplorers
            // 
            this.dgvExplorers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExplorers.Location = new System.Drawing.Point(12, 12);
            this.dgvExplorers.Name = "dgvExplorers";
            this.dgvExplorers.Size = new System.Drawing.Size(1202, 492);
            this.dgvExplorers.TabIndex = 0;
            this.dgvExplorers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvExplorers_MouseClick_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalSurveyToolStripMenuItem,
            this.employerSurveyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 70);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 615);
            this.Controls.Add(this.dgvExplorers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExplorers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExplorers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personalSurveyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employerSurveyToolStripMenuItem;
    }
}

