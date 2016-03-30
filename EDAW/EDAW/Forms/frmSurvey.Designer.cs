namespace EDAW.Forms
{
    partial class FormSurvey
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
            this.dgvPersonal = new System.Windows.Forms.DataGridView();
            this.btnAnalysis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonal.Location = new System.Drawing.Point(13, 86);
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.Size = new System.Drawing.Size(878, 550);
            this.dgvPersonal.TabIndex = 0;
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Location = new System.Drawing.Point(13, 23);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(144, 47);
            this.btnAnalysis.TabIndex = 1;
            this.btnAnalysis.Text = "Analysis";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnPersonalSurvy_Click);
            // 
            // FormSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 648);
            this.Controls.Add(this.btnAnalysis);
            this.Controls.Add(this.dgvPersonal);
            this.Name = "FormSurvey";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonal;
        private System.Windows.Forms.Button btnAnalysis;
    }
}