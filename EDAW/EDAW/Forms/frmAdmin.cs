using EDAW.App.Data;
using EDAW.Contexts;
using EDAW.Data;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDAW.Forms
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();

            cboSecurity.DataSource = Enum.GetValues(typeof(User.SecurityLevel));
            cboEditSecurity.DataSource = Enum.GetValues(typeof(User.SecurityLevel));

            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            colUsername.DataPropertyName = "username";
            colSecLevel.DataPropertyName = "securityLevel";
            colSavePath.DataPropertyName = "savePath";

            RefreshView();
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count != 0)
            {
                User selected = dgvUsers.SelectedRows[0].DataBoundItem as User;
                if (selected != null)
                {
                    txtEditUsername.Text = selected.username;
                    txtEditPw.Text = selected.password;
                    txtEditSavePath.Text = selected.savePath;
                    cboEditSecurity.SelectedItem = selected.securityLevel;
                }
                else
                {
                    foreach (Control cntrl in groupEdit.Controls)
                    {
                        if (cntrl.GetType() == typeof(TextBox))
                        {
                            (cntrl as TextBox).Text = String.Empty;
                        }
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //usernames must be unique
            if (UserManager.Find(usr => usr.username.Equals(txtName.Text)).Count() > 0)
            {
                MessageBox.Show("This user already exists");
                return;
            }
            User addUser = new User(txtName.Text, txtPass.Text, (User.SecurityLevel)cboSecurity.SelectedItem, txtSavePth.Text);

            UserManager.Add(addUser);

            RefreshView();
        }

        private void RefreshView()
        {
            IQueryable<User> users = UserManager.Users;

            BindingList<User> bind = new BindingList<User>(users.ToList());

            dgvUsers.DataSource = (bind as IBindingList);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmConfirm confirm = new frmConfirm("This will delete the current user and cannot be undone. Do you want to delete the current user?");
            confirm.ShowDialog();
            
            if (confirm.DialogResult == DialogResult.Yes)
            {
                User toDelete = dgvUsers.SelectedRows[0].DataBoundItem as User;

                UserManager.Delete(toDelete);

                RefreshView();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User toUpdate = dgvUsers.SelectedRows[0].DataBoundItem as User;

            var builder = Builders<User>.Update;
            var update = builder.Set(usr => usr.username, txtEditUsername.Text).Set(usr => usr.password, txtEditPw.Text)
                .Set(usr => usr.savePath, txtEditSavePath.Text).Set(usr => usr.securityLevel, (User.SecurityLevel)cboEditSecurity.SelectedIndex);

            UserManager.Update(toUpdate, update);

            if (toUpdate.username.Equals(AppEnvironment.currentUser.username))
            {
                AppEnvironment.currentUser = toUpdate;
            }

            RefreshView();
        }
    }
}
