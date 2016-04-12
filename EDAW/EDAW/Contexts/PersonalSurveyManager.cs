using EDAW.Data;
using EDAW.Database;
using EDAW.Objects;
using MongoDB.Driver;
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

        public static void Update(PersonalSurvey survey, UpdateDefinition<PersonalSurvey> update)
        {
            DBContext.Current.Update<PersonalSurvey>(x => x.id == survey.id, update);
        }
    }
}
