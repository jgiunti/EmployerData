using EDAW.Data;
using EDAW.Objects;
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
    public partial class FormSurvey : Form
    {
        public FormSurvey()
        {
            InitializeComponent();
            dgvPersonal.ReadOnly = true;
            dgvPersonal.AutoGenerateColumns = true;           
        }

        public void LoadSurvey<T>(List<T> collection ) where T : class, new()
        {     
            dgvPersonal.DataSource = (collection);
        }

        private void btnPersonalSurvy_Click(object sender, EventArgs e)
        {
            
        }
    }
}
