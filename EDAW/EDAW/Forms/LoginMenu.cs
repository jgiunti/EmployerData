using EDAW.App.Data;
using EDAW.Contexts;
using EDAW.Data;
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
    public partial class LoginMenu : Form
    {
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void button_submit_Click(object sender, EventArgs e)
        {          
            IEnumerable<User> temp_user = UserManager.Find(x => x.username == txt_username.Text);
            if (temp_user.Count() == 0)
            {
                MessageBox.Show("Invalid Username");
                return;
            }
            User self = temp_user.FirstOrDefault();
            if (self == null) {
                MessageBox.Show("Incorrect");
                return;
            }           
            if (txt_password.Text.Equals("") || txt_username.Text.Equals(""))
            {
                MessageBox.Show("Please enter a valid username and password\n");
            }
            else
            {
                try
                {
                    if(!self.password.Equals(txt_password.Text)){
                        MessageBox.Show("Incorrect Username or Password\n");
                    }
                    else
                    {
                        AppEnvironment.currentUser = self;
                        this.Hide();
                        new Form1().ShowDialog();
                    }                                     
                }
                catch
                {

                }
            }
            this.Close();
        }

        private void LoginMenu_Load(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
