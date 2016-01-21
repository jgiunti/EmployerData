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
            Mongo.Initialize();

            JobExplrContext jec = new JobExplrContext();
            IMongoCollection<JobExplorer> jeCtxt = jec.JobExplorers;

            System.Diagnostics.Debug.WriteLine(jeCtxt.AsQueryable().First().ToJson());
            //jeCtxt.InsertOne(new JobExplorer());
            
        }
    }
}
