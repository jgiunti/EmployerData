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
    public partial class FormSurvey : Form
    {
        public FormSurvey()
        {
            InitializeComponent();
            dgvSurvey.ReadOnly = true;
            dgvSurvey.AutoGenerateColumns = true;           
        }

        public void LoadSurvey<T>(List<T> collection ) where T : class, new()
        {     
            dgvSurvey.DataSource = (collection);
        }

        private void btnPersonalSurvy_Click(object sender, EventArgs e)
        {
            IReport report = new Top10EmpValues();
            report.DrawReport();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DataExporter exporter = new DataExporter(dgvSurvey);

            exporter.Export();
        }
    }
}
