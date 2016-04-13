using EDAW.Data;
using EDAW.Database;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDAW.Contexts
{
    public static class EmployerManager
    {
        public static IQueryable<Employer> employers
        {
            get
            {
                return DBContext.Current.All<Employer>();
            }
        }

        public static IEnumerable<Employer> Find(Func<Employer, bool> predicate)
        {
            return employers.AsQueryable().Where(predicate);
        }

        public static IEnumerable<Employer> Find(Employer employer)
        {
            return employers.AsQueryable().Where(x => employer.id == x.id);
        }

        public static void Add(Employer employer)
        {
            DBContext.Current.Add<Employer>(employer);
        }

        public static void Update(Employer survey, UpdateDefinition<Employer> update)
        {
            DBContext.Current.Update<Employer>(x => x.id == survey.id, update);
        }
    }
}
