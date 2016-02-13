using EDAW.Contexts;
using EDAW.Data;
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
            
            IQueryable<JobExplorer> test = JobExplorerManager.JobExplorers;

            JobExplorer je = test.First();

            IEnumerable<PersonalSurvey> ips = je.PersonalSurveyList;

            IEnumerable<EmployerSurvey> eps = je.EmployerSurveyList;

            List<EmployerSurvey> epl = eps.ToList();

            List<PersonalSurvey> psl = ips.ToList();

            BindingList<JobExplorer> jlist = new BindingList<JobExplorer>(test.ToList());

            dgvExplorers.DataSource = (jlist as IBindingList);                       
        }
    }
}
