using EDAW.Data;
using EDAW.Database;
using EDAW.Objects;
using System.Collections.Generic;
using System.Linq;

namespace EDAW.Contexts
{
    public static class EmployerSurveyManager
    {
        public static IQueryable<EmployerSurvey> EmployerSurveys
        {
            get
            {
                return DBContext.Current.All<EmployerSurvey>();
            }
        }

        public static IEnumerable<EmployerSurvey> Find(JobExplorer jobExplorer)
        {
            return EmployerSurveys.AsQueryable().Where(x => jobExplorer.employerSurveys.Contains(x.id));
        }
    }
}
