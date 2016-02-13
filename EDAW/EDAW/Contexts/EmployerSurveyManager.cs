using EDAW.Database;
using EDAW.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
