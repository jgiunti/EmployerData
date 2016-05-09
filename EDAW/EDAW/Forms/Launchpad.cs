using EDAW.Contexts;
using EDAW.Data;
using EDAW.ExcelSpace;
using EDAW.Forms;
using EDAW.Interfaces;
using EDAW.Objects;
using MongoDB.Driver;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System;
using MongoDB.Bson;
using EDAW.Utilities;
using EDAW.Reports;
using EDAW.App.Data;

namespace EDAW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (AppEnvironment.currentUser.securityLevel != User.SecurityLevel.admin)
            {
                groupAdmin.Hide();
            }
            dgvExplorers.AutoGenerateColumns = false;
            dgvExplorers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            colOccupation.DataPropertyName = "occupation";
            colJobLvl.DataPropertyName = "joblevel";
            colJobLvlOthr.DataPropertyName = "joblevel_other";
            colExpert.DataPropertyName = "expertise";
            colEducation.DataPropertyName = "education";
            colEducationOthr.DataPropertyName = "education_other";
            colGener.DataPropertyName = "gender";                              

            dgvExplorers.ReadOnly = true;
            
            IQueryable<JobExplorer> allExplorers = JobExplorerManager.JobExplorers;           

            BindingList<JobExplorer> bind = new BindingList<JobExplorer>(allExplorers.ToList());

            dgvExplorers.DataSource = (bind as IBindingList);

            List<IReport> reportList = new List<IReport>();

            reportList.Add(new Top10EmpValues());

            lstReports.DataSource = reportList;          
        }

        private void personalSurveyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            JobExplorer explorer = dgvExplorers.SelectedRows[0].DataBoundItem as JobExplorer;

            List<PersonalSurvey> survey = explorer.PersonalSurveyList.ToList();

            FrmPersonalSurvey frmSrvy = new FrmPersonalSurvey();
            frmSrvy.LoadSurvey<PersonalSurvey>(survey);

            frmSrvy.Show();
        }

        private void dgvExplorers_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(dgvExplorers, new System.Drawing.Point(e.X, e.Y));
            }
        }

        private void employerSurveyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            JobExplorer explorer = dgvExplorers.SelectedRows[0].DataBoundItem as JobExplorer;
            List<EmployerSurvey> survey = explorer.EmployerSurveyList.ToList();

            frmEmpSurvey frmSrvy = new frmEmpSurvey();
            frmSrvy.LoadSurvey<EmployerSurvey>(survey);

            frmSrvy.Show();
        }

        private void dgvExplorers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex > -1)
            //{
            //    dgvExplorers.Rows[e.RowIndex].Selected = true;
            //}
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DataExporter exporter = new DataExporter(dgvExplorers);

            exporter.Export();
        }

        private void btnTop10_Click(object sender, EventArgs e)
        {
            IReport top10 = lstReports.SelectedItem as IReport;//new Top10EmpValues();
            top10.DrawReport();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin admin = new frmAdmin();
            admin.Show();
        }
    }
}
