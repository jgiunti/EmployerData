using EDAW.Contexts;
using EDAW.Data;
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

            IQueryable<User> users = UserManager.Users;

            BindingList<User> bind = new BindingList<User>(users.ToList());

            dgvUsers.DataSource = (bind as IBindingList);
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
    }
}
