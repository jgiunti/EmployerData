using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using EDAW.Objects;

namespace EDAW.Data
{
    [BsonIgnoreExtraElements]
    class JobExplorer
    {
        public enum Gender
        {
            Male,
            Female
        };

        public ObjectId id;
        

        //public Gender gender;
        //[BsonIgnore]
        //private PersonalSurvey _pSurvey;
        //public PersonalSurvey pSurvey
        //{
        //    get
        //    {
        //        return new PersonalSurvey();
        //    }
        //    set
        //    {

        //    }
        //}

        public string TimeStamp { get; set; }
        public int IC { get; set; }
        public string  occupation { get; set; }
        public string joblevel { get; set; }
        public string joblevel_other { get; set; }
        public string expertise { get; set; }
        public int education { get; set; }
        public string education_other { get; set; }
        public int gender { get; set; }


        //SURVEY STUFF
        //public int worklife_self;
        //public int jobsec_self;
        //public int td_self;
        //public int workload_self;
        //public int careerpath_self;
        //public int promocrit_self;
        //public int promo_self;
        //public int auton_self;
        //public int salary_self;
        //public int goodsup_self;
        //public int flex_self;
        //public int rewperf_self;
        //public int mission_self;
        //public int health_self;
        //public int rewrecog_self;
        //public int workspace_self;
        //public int poorperfs_self;
        //public int cur_or_form;
        //public int jobsec_cur;
        //public int worklife_cur;
        //public int workload_cur;
        //public int careerpath_cur;
        //public int td_cur;
        //public int promo_cur;
        //public int goodsup_cur;
        //public int auton_cur;
        //public int promocrit_cur;
        //public int salary_cur;
        //public int flex_cur;
        //public int rewperf_cur;
        //public int mission_cur;
        //public int health_cur;
        //public int rewrecog_cur;
        //public int workspace_cur;
        //public int poorperfs_cur;
        //public int careless1;
        //public int jobsat;
        //public int commit;
        //public int itl;
        //public int careless2;
        //public int values ;
        //public int jobperf;
        //public int coop;
        //public int help;
        //public int court;
        //public string cur_emp_name;
        //public int cur_state;
        //public string cur_town;
        //public string curr_city_country;
        //public string cur_ten_years;
        //public int cur_ten_mos;
        //public int hours_per_week_work;
        //public int jobsec_for;
        //public int workload_for;
        //public int worklife_for;
        //public int careerpath_for;
        //public int td_for;
        //public int goodsup_for;
        //public int promo_for;
        //public int auton_for;
        //public int promocrit_for;
        //public int salary_for;
        //public int flex_for;
        //public int rewperf_for;
        //public int mission_for;
        //public int health_for;
        //public int rewrecog_for;
        //public int workspace_for;
        //public int poorperfs_for;
        //public int for_emp_name;
        //public int for_state;
        //public int for_town;
        //public int curr_city_country_intl;
        //public int for_sepyear;
        //public int for_ten_years;
        //public int for_ten_mos;
        //public int for_leave_choice;
        //public int hours_per_week2;
        //public string comments;


        public JobExplorer()
        {
            
        }
    }
}
