using EDAW.Data;
using EDAW.Database;
using EDAW.Objects;
using MongoDB.Driver;
using System;
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

        public static IEnumerable<EmployerSurvey> Find(Func<EmployerSurvey, bool> predicate)
        {
            return EmployerSurveys.AsQueryable().Where(predicate);
        }

        public static IEnumerable<EmployerSurvey> Find(JobExplorer jobExplorer)
        {
            return EmployerSurveys.AsQueryable().Where(x => jobExplorer.employerSurveys.Contains(x.id));
        }

        public static void Add(EmployerSurvey survey)
        {
            DBContext.Current.Add<EmployerSurvey>(survey);
        }

        public static void Update(EmployerSurvey survey, UpdateDefinition<EmployerSurvey> update)
        {
            DBContext.Current.Update<EmployerSurvey>(x => x.id == survey.id, update);
        }
    }
}
