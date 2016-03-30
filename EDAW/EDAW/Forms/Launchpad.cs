using EDAW.Contexts;
using EDAW.Data;
using EDAW.Forms;
using EDAW.Objects;
using MongoDB.Driver;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace EDAW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dgvExplorers.ReadOnly = true;
            
            IQueryable<JobExplorer> test = JobExplorerManager.JobExplorers;

            JobExplorer je = test.First();

            IEnumerable<PersonalSurvey> ips = je.PersonalSurveyList;

            IEnumerable<EmployerSurvey> eps = je.EmployerSurveyList;

            List<EmployerSurvey> epl = eps.ToList();

            List<PersonalSurvey> psl = ips.ToList();

            BindingList<JobExplorer> jlist = new BindingList<JobExplorer>(test.ToList());

            dgvExplorers.DataSource = (jlist as IBindingList);                       
        }

        private void dgvExplorers_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //ContextMenu surveyOptions = new ContextMenu();
                //surveyOptions.MenuItems.Add(new MenuItem("Personal Survey"));
                //surveyOptions.MenuItems.Add(new MenuItem("Employer Survey"));

                ContextMenuStrip surveyOptions = new ContextMenuStrip();
                
                int mouseOverIndex = dgvExplorers.HitTest(e.X, e.Y).RowIndex;

                surveyOptions.Show(dgvExplorers, new System.Drawing.Point(e.X, e.Y));

                JobExplorer explorer = dgvExplorers.Rows[mouseOverIndex].DataBoundItem as JobExplorer;

                List<PersonalSurvey> survey = explorer.PersonalSurveyList.ToList();





            }
        }

        private void personalSurveyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            //int mouseOverIndex = dgvExplorers.HitTest(e.X, e.Y).RowIndex;
            JobExplorer explorer = dgvExplorers.SelectedRows[0].DataBoundItem as JobExplorer;
            //JobExplorer explorer = dgvExplorers.Rows[1].DataBoundItem as JobExplorer;

            List<PersonalSurvey> survey = explorer.PersonalSurveyList.ToList();

            FormSurvey frmSrvy = new FormSurvey();
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

            FormSurvey frmSrvy = new FormSurvey();
            frmSrvy.LoadSurvey<EmployerSurvey>(survey);

            frmSrvy.Show();
        }
    }
}
