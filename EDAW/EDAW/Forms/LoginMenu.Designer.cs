namespace EDAW.Forms
{
    partial class LoginMenu
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.UserTxt = new System.Windows.Forms.Label();
            this.pass_label = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.btnConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(146, 70);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(188, 20);
            this.txt_username.TabIndex = 0;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // UserTxt
            // 
            this.UserTxt.AutoSize = true;
            this.UserTxt.Location = new System.Drawing.Point(61, 70);
            this.UserTxt.Name = "UserTxt";
            this.UserTxt.Size = new System.Drawing.Size(57, 13);
            this.UserTxt.TabIndex = 1;
            this.UserTxt.Text = "UserName";
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Location = new System.Drawing.Point(61, 126);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(53, 13);
            this.pass_label.TabIndex = 2;
            this.pass_label.Text = "Password";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(146, 126);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(188, 20);
            this.txt_password.TabIndex = 3;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(126, 21);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(103, 13);
            this.Title.TabIndex = 4;
            this.Title.Text = "Job Exploration Tool";
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(64, 188);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 5;
            this.button_submit.Text = "Login";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(217, 188);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(75, 23);
            this.btnConnection.TabIndex = 6;
            this.btnConnection.Text = "Connection";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // LoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 262);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.UserTxt);
            this.Controls.Add(this.txt_username);
            this.Name = "LoginMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginMenu";
            this.Load += new System.EventHandler(this.LoginMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label UserTxt;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Button btnConnection;
    }
}