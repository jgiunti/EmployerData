using EDAW.Contexts;
using EDAW.Data;
using EDAW.Interfaces;
using EDAW.Objects;
using EDAW.Reports;
using EDAW.Utilities;
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
    public partial class FrmPersonalSurvey : Form
    {
        bool personal = false;
        bool employer = false;

        public FrmPersonalSurvey()
        {
            InitializeComponent();
            dgvSurvey.ReadOnly = true;
            dgvSurvey.AutoGenerateColumns = true;

            IQueryable<Employer> employers = EmployerManager.employers;

            BindingList<Employer> bind = new BindingList<Employer>(employers.ToList());

            cboEmployers.DisplayMember = "employerName";

            cboEmployers.DataSource = (bind as IBindingList);
        }

        public void LoadSurvey<T>(List<PersonalSurvey> collection ) where T : class, new()
        {     
            dgvSurvey.DataSource = (collection);
        }

        private void btnRun_click(object sender, EventArgs e)
        {
            IReport report;
            if (rdoChange.Checked)
            {
                report = new ChangeOverTime(dgvSurvey.DataSource as List<PersonalSurvey>);
                report.DrawReport();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DataExporter exporter = new DataExporter(dgvSurvey);

            exporter.Export();
        }
    }
}
