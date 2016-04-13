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

            dgvUsers.AutoGenerateColumns = false;
            colUsername.DataPropertyName = "username";
            colSecLevel.DataPropertyName = "securityLevel";
            colSavePath.DataPropertyName = "savePath";

            IQueryable<User> users = UserManager.Users;

            BindingList<User> bind = new BindingList<User>(users.ToList());

            dgvUsers.DataSource = (bind as IBindingList);
        }
    }
}
