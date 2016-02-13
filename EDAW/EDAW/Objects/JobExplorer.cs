using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

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
        public List<ObjectId> personalSurveys;
        public List<ObjectId> employerSurveys;       

        public JobExplorer()
        {
            this.personalSurveys = new List<ObjectId>();
            this.employerSurveys = new List<ObjectId>();
        }
    }
}
