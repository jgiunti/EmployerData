using EDAW.Contexts;
using EDAW.Data;
using MongoDB.Driver;
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

            dgvExplorers.AutoGenerateColumns = true;

            BindingList<JobExplorer> jlist = new BindingList<JobExplorer>(test.ToList());

            dgvExplorers.DataSource = (jlist as IBindingList);                       
        }
    }
}
