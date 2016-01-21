using EDAW.Data;
using EDAW.Database;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDAW.Contexts
{
    class JobExplrContext
    {       
        public JobExplrContext()
        {           
        }

        public IMongoCollection<JobExplorer> JobExplorers
        {
            get
            {
                return Mongo.DbContext.GetCollection<JobExplorer>("JobExplorers");
            }
        }

        public IEnumerable<JobExplorer> Find(Func<JobExplorer, bool> predicate)
        {
            return JobExplorers.AsQueryable().Where(predicate);
        }

        public void Add(JobExplorer explorer)
        {

        }
    }
}
