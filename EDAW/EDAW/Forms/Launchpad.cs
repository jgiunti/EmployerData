using EDAW.Contexts;
using EDAW.Data;
using EDAW.Database;
using EDAW.Objects;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDAW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            JobExplrContext jec = new JobExplrContext();
            IQueryable<JobExplorer> test = jec.JobExplorers;

            int cnt = test.Count();
            
            foreach (JobExplorer je in test)
            {               
                System.Diagnostics.Debug.WriteLine(je.ToJson());
            }                        
        }
    }
}
