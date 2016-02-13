using EDAW.Contexts;
using EDAW.Data;
using EDAW.Database;
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

            JobExplorer bob = test.First();

            System.Diagnostics.Debug.WriteLine(test.First().ToJson());
            //jeCtxt.InsertOne(new JobExplorer());
            
        }
    }
}
