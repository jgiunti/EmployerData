using EDAW.Objects;
using EDAW.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EDAW.Forms
{
    public partial class frmEmpSurvey : Form
    {
        public frmEmpSurvey()
        {
            InitializeComponent();
        }

        public void LoadSurvey<T>(List<EmployerSurvey> collection) where T : class, new()
        {
            dgvSurvey.DataSource = (collection);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DataExporter exporter = new DataExporter(dgvSurvey);

            exporter.Export();
        }
    }
}
