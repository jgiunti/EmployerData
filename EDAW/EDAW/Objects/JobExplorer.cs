using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using EDAW.Objects;
using EDAW.Contexts;

namespace EDAW.Data
{
    [BsonIgnoreExtraElements]
    public class JobExplorer
    {
        public enum Gender
        {
            Male,
            Female
        };

        public ObjectId id;

        [BsonIgnoreIfNull]
        public int IC { get; set; }
        public string  occupation { get; set; }
        public string joblevel { get; set; }
        public string joblevel_other { get; set; }
        public string expertise { get; set; }
        public string education { get; set; }
        public string education_other { get; set; }
        public Gender gender { get; set; }
        public IEnumerable<PersonalSurvey> PersonalSurveyList
        {
            get
            {
                return PersonalSurveyManager.Find(this);
            }
        }
        public IEnumerable<EmployerSurvey> EmployerSurveyList
        {
            get
            {
                return EmployerSurveyManager.Find(this);
            }
        }
        public List<ObjectId> personalSurveys;
        public List<ObjectId> employerSurveys;       

        public JobExplorer()
        {
        }
    }
}
