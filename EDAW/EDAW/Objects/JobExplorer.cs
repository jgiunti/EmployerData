using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace EDAW.Data
{
    class JobExplorer
    {
        public enum Gender
        {
            Male,
            Female
        };

        public ObjectId id;
        public Gender gender;
        public string occupation;
        public string joblevel;
        public string joblevel_other;
        public string expertise;
        public string education;
        public string education_other;
        public string comments;

        public JobExplorer()
        {
            this.gender = Gender.Male;
            this.occupation = "plumber";
            this.joblevel = "manager";
            this.joblevel_other = "manager";
            this.expertise = "cs";
            this.education =  "masters";
            this.education_other = "none";
            this.comments = "test";
        }
    }
}
