using EDAW.Data;
using EDAW.Database;
using EDAW.Objects;
using System.Collections.Generic;
using System.Linq;

namespace EDAW.Contexts
{
    public static class PersonalSurveyManager
    {
        public static IQueryable<PersonalSurvey> PersonalSurveys
        {
            get
            {
                return DBContext.Current.All<PersonalSurvey>();
            }
        }

        public static IEnumerable<PersonalSurvey> Find(JobExplorer jobExplorer)
        {
            return PersonalSurveys.AsQueryable().Where(x => jobExplorer.personalSurveys.Contains(x.id));
        }
    }
}
