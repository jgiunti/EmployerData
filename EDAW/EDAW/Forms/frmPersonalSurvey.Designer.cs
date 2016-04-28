namespace EDAW.Forms
{
    partial class FrmPersonalSurvey
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
            this.dgvSurvey = new System.Windows.Forms.DataGridView();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.rdoChange = new System.Windows.Forms.RadioButton();
            this.rdoMisMatch = new System.Windows.Forms.RadioButton();
            this.cboEmployers = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSurvey)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSurvey
            // 
            this.dgvSurvey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSurvey.Location = new System.Drawing.Point(13, 86);
            this.dgvSurvey.Name = "dgvSurvey";
            this.dgvSurvey.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSurvey.Size = new System.Drawing.Size(878, 550);
            this.dgvSurvey.TabIndex = 0;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(13, 23);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(144, 47);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run Report";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(174, 23);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(144, 47);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // rdoChange
            // 
            this.rdoChange.AutoSize = true;
            this.rdoChange.Location = new System.Drawing.Point(436, 23);
            this.rdoChange.Name = "rdoChange";
            this.rdoChange.Size = new System.Drawing.Size(114, 17);
            this.rdoChange.TabIndex = 3;
            this.rdoChange.TabStop = true;
            this.rdoChange.Text = "Change Over Time";
            this.rdoChange.UseVisualStyleBackColor = true;
            // 
            // rdoMisMatch
            // 
            this.rdoMisMatch.AutoSize = true;
            this.rdoMisMatch.Location = new System.Drawing.Point(566, 23);
            this.rdoMisMatch.Name = "rdoMisMatch";
            this.rdoMisMatch.Size = new System.Drawing.Size(116, 17);
            this.rdoMisMatch.TabIndex = 4;
            this.rdoMisMatch.TabStop = true;
            this.rdoMisMatch.Text = "Employer Mismatch";
            this.rdoMisMatch.UseVisualStyleBackColor = true;
            // 
            // cboEmployers
            // 
            this.cboEmployers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployers.FormattingEnabled = true;
            this.cboEmployers.Location = new System.Drawing.Point(566, 47);
            this.cboEmployers.Name = "cboEmployers";
            this.cboEmployers.Size = new System.Drawing.Size(121, 21);
            this.cboEmployers.TabIndex = 5;
            // 
            // FrmPersonalSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 648);
            this.Controls.Add(this.cboEmployers);
            this.Controls.Add(this.rdoMisMatch);
            this.Controls.Add(this.rdoChange);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.dgvSurvey);
            this.Name = "FrmPersonalSurvey";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSurvey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSurvey;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.RadioButton rdoChange;
        private System.Windows.Forms.RadioButton rdoMisMatch;
        private System.Windows.Forms.ComboBox cboEmployers;
    }
}