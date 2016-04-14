namespace EDAW.Forms
{
    partial class frmAdmin
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSecLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSavePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAddUser = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtSavePth = new System.Windows.Forms.TextBox();
            this.cboSecurity = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            this.lblSecurity = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupEdit = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboEditSecurity = new System.Windows.Forms.ComboBox();
            this.txtEditSavePath = new System.Windows.Forms.TextBox();
            this.txtEditPw = new System.Windows.Forms.TextBox();
            this.txtEditUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.grpAddUser.SuspendLayout();
            this.groupEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUsername,
            this.colSecLevel,
            this.colSavePath});
            this.dgvUsers.Location = new System.Drawing.Point(414, 12);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(438, 520);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.SelectionChanged += new System.EventHandler(this.dgvUsers_SelectionChanged);
            // 
            // colUsername
            // 
            this.colUsername.HeaderText = "Username";
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            this.colUsername.Width = 125;
            // 
            // colSecLevel
            // 
            this.colSecLevel.HeaderText = "Security Level";
            this.colSecLevel.Name = "colSecLevel";
            this.colSecLevel.ReadOnly = true;
            // 
            // colSavePath
            // 
            this.colSavePath.HeaderText = "Save Path";
            this.colSavePath.Name = "colSavePath";
            this.colSavePath.Width = 170;
            // 
            // grpAddUser
            // 
            this.grpAddUser.Controls.Add(this.btnAdd);
            this.grpAddUser.Controls.Add(this.lblSecurity);
            this.grpAddUser.Controls.Add(this.lblSave);
            this.grpAddUser.Controls.Add(this.lblPassword);
            this.grpAddUser.Controls.Add(this.lblName);
            this.grpAddUser.Controls.Add(this.cboSecurity);
            this.grpAddUser.Controls.Add(this.txtSavePth);
            this.grpAddUser.Controls.Add(this.txtPass);
            this.grpAddUser.Controls.Add(this.txtName);
            this.grpAddUser.Location = new System.Drawing.Point(12, 12);
            this.grpAddUser.Name = "grpAddUser";
            this.grpAddUser.Size = new System.Drawing.Size(396, 192);
            this.grpAddUser.TabIndex = 1;
            this.grpAddUser.TabStop = false;
            this.grpAddUser.Text = "Add User";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(118, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(6, 92);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(118, 20);
            this.txtPass.TabIndex = 1;
            // 
            // txtSavePth
            // 
            this.txtSavePth.Location = new System.Drawing.Point(145, 44);
            this.txtSavePth.Name = "txtSavePth";
            this.txtSavePth.Size = new System.Drawing.Size(245, 20);
            this.txtSavePth.TabIndex = 2;
            // 
            // cboSecurity
            // 
            this.cboSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSecurity.FormattingEnabled = true;
            this.cboSecurity.Location = new System.Drawing.Point(145, 91);
            this.cboSecurity.Name = "cboSecurity";
            this.cboSecurity.Size = new System.Drawing.Size(121, 21);
            this.cboSecurity.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 76);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(142, 28);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(57, 13);
            this.lblSave.TabIndex = 6;
            this.lblSave.Text = "Save Path";
            // 
            // lblSecurity
            // 
            this.lblSecurity.AutoSize = true;
            this.lblSecurity.Location = new System.Drawing.Point(142, 75);
            this.lblSecurity.Name = "lblSecurity";
            this.lblSecurity.Size = new System.Drawing.Size(74, 13);
            this.lblSecurity.TabIndex = 7;
            this.lblSecurity.Text = "Security Level";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 133);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // groupEdit
            // 
            this.groupEdit.Controls.Add(this.button1);
            this.groupEdit.Controls.Add(this.label1);
            this.groupEdit.Controls.Add(this.label2);
            this.groupEdit.Controls.Add(this.label3);
            this.groupEdit.Controls.Add(this.label4);
            this.groupEdit.Controls.Add(this.cboEditSecurity);
            this.groupEdit.Controls.Add(this.txtEditSavePath);
            this.groupEdit.Controls.Add(this.txtEditPw);
            this.groupEdit.Controls.Add(this.txtEditUsername);
            this.groupEdit.Location = new System.Drawing.Point(12, 288);
            this.groupEdit.Name = "groupEdit";
            this.groupEdit.Size = new System.Drawing.Size(396, 192);
            this.groupEdit.TabIndex = 2;
            this.groupEdit.TabStop = false;
            this.groupEdit.Text = "Edit User";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Security Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Save Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username";
            // 
            // cboEditSecurity
            // 
            this.cboEditSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEditSecurity.FormattingEnabled = true;
            this.cboEditSecurity.Location = new System.Drawing.Point(145, 91);
            this.cboEditSecurity.Name = "cboEditSecurity";
            this.cboEditSecurity.Size = new System.Drawing.Size(121, 21);
            this.cboEditSecurity.TabIndex = 3;
            // 
            // txtEditSavePath
            // 
            this.txtEditSavePath.Location = new System.Drawing.Point(145, 44);
            this.txtEditSavePath.Name = "txtEditSavePath";
            this.txtEditSavePath.Size = new System.Drawing.Size(245, 20);
            this.txtEditSavePath.TabIndex = 2;
            // 
            // txtEditPw
            // 
            this.txtEditPw.Location = new System.Drawing.Point(6, 92);
            this.txtEditPw.Name = "txtEditPw";
            this.txtEditPw.Size = new System.Drawing.Size(118, 20);
            this.txtEditPw.TabIndex = 1;
            // 
            // txtEditUsername
            // 
            this.txtEditUsername.Location = new System.Drawing.Point(6, 44);
            this.txtEditUsername.Name = "txtEditUsername";
            this.txtEditUsername.Size = new System.Drawing.Size(118, 20);
            this.txtEditUsername.TabIndex = 0;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 544);
            this.Controls.Add(this.groupEdit);
            this.Controls.Add(this.grpAddUser);
            this.Controls.Add(this.dgvUsers);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.grpAddUser.ResumeLayout(false);
            this.grpAddUser.PerformLayout();
            this.groupEdit.ResumeLayout(false);
            this.groupEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSecLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSavePath;
        private System.Windows.Forms.GroupBox grpAddUser;
        private System.Windows.Forms.ComboBox cboSecurity;
        private System.Windows.Forms.TextBox txtSavePth;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSecurity;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboEditSecurity;
        private System.Windows.Forms.TextBox txtEditSavePath;
        private System.Windows.Forms.TextBox txtEditPw;
        private System.Windows.Forms.TextBox txtEditUsername;
    }
}