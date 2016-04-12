using EDAW.Data;
using EDAW.Database;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EDAW.Contexts
{
    public static class JobExplorerManager
    {       
        public static IQueryable<JobExplorer> JobExplorers
        {
            get
            {
                return DBContext.Current.All<JobExplorer>();
            }
        }

        public static IEnumerable<JobExplorer> Find(Func<JobExplorer, bool> predicate)
        {
            return JobExplorers.AsQueryable().Where(predicate);
        }

        public static void Add(JobExplorer explorer)
        {
            DBContext.Current.Add<JobExplorer>(explorer);
        }

        public static void Add(IEnumerable<JobExplorer> jobExplorerList)
        {
            DBContext.Current.Add<JobExplorer>(jobExplorerList);
        }

        public static void Delete(JobExplorer jobExplorer)
        {
            DBContext.Current.Delete<JobExplorer>(x => x.id == jobExplorer.id);
        }

        public static void Update(JobExplorer jobExplorer, UpdateDefinition<JobExplorer> update)
        {
            DBContext.Current.Update<JobExplorer>(x => x.id == jobExplorer.id, update);
        }
    }
}
