using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDAW.Objects
{
    public class PersonalSurvey
    {
        public ObjectId id;
        [BsonIgnoreIfNull]
        public string timeStamp { get; set; }
        public int worklife_self { get; set; }
        public int jobsec_self { get; set; }
        public int td_self { get; set; }
        public int workload_self { get; set; }
        public int careerpath_self { get; set; }
        public int promocrit_self { get; set; }
        public int promo_self { get; set; }
        public int auton_self { get; set; }
        public int salary_self { get; set; }
        public int goodsup_self { get; set; }
        public int flex_self { get; set; }
        public int rewperf_self { get; set; }
        public int mission_self { get; set; }
        public int health_self { get; set; }
        public int rewrecog_self { get; set; }
        public int workspace_self { get; set; }
        public int poorperfs_self { get; set; }

        public PersonalSurvey(int wls, int jobsec, int td, int workld, int creerpth, int promcrit, int promsel, int auton, int sal,
            int goosp, int flex, int reperf, int mission, int health, int rewrec, int wrk, int poorperf, string ts)
        {
            this.worklife_self = wls;
            this.jobsec_self = jobsec;
            this.td_self = td;
            this.workload_self = workld;
            this.careerpath_self = creerpth;
            this.promocrit_self = promcrit;
            this.promo_self = promsel;
            this.auton_self = auton;
            this.salary_self = sal;
            this.goodsup_self = goosp;
            this.flex_self = flex;
            this.rewperf_self = reperf;
            this.mission_self = mission;
            this.health_self = health;
            this.rewrecog_self = rewrec;
            this.workspace_self = wrk;
            this.poorperfs_self = poorperf;
            this.timeStamp = ts;
        }

        public PersonalSurvey()
        {

        }
    }
}
