using MongoDB.Bson;

namespace EDAW.Objects
{
    public class EmployerSurvey
    {
        public ObjectId id;

        public int cur_or_form { get; set; }
        public int jobsec_cur { get; set; }
        public int worklife_cur { get; set; }
        public int workload_cur { get; set; }
        public int careerpath_cur { get; set; }
        public int td_cur { get; set; }
        public int promo_cur { get; set; }
        public int goodsup_cur { get; set; }
        public int auton_cur { get; set; }
        public int promocrit_cur { get; set; }
        public int salary_cur { get; set; }
        public int flex_cur { get; set; }
        public int rewperf_cur { get; set; }
        public int mission_cur { get; set; }
        public int health_cur { get; set; }
        public int rewrecog_cur { get; set; }
        public int workspace_cur { get; set; }
        public int poorperfs_cur { get; set; }
        public int jobsat { get; set; }
        public int commit { get; set; }
        public int itl { get; set; }
        public int values { get; set; }
        public int jobperf { get; set; }
        public int coop { get; set; }
        public int help { get; set; }
        public int court { get; set; }
        public string cur_emp_name { get; set; }
        public string cur_state { get; set; }
        public string cur_town { get; set; }
        public string curr_city_country { get; set; }
        public int cur_ten_years { get; set; }
        public int cur_ten_mos { get; set; }
        public int hours_per_week_work { get; set; }
        public string comments { get; set; }
        public string timeStamp { get; set; }

        public EmployerSurvey(int cur_or_form, int jobsec_cur, int worklife_cur, int workload_cur, int careerpath_cur, int td_cur, int promo_cur, int goodsup_cur, int auton_cur, int promocrit_cur,
            int salary_cur, int flex_cur, int rewperf_cur, int mission_cur, int health_cur, int rewrecog_cur, int workspace_cur, int poorperfs_cur, int jobsat, int commit,
            int itl, int values, int jobperf, int coop, int help, int court, string cur_emp_name, string cur_state, string cur_town, string curr_city_country, int cur_ten_years,
            int cur_ten_mos, int hours_per_week_work, string comments, string timeStamp)
        {
             this.cur_or_form = cur_or_form;
             this.jobsec_cur = jobsec_cur;
             this.worklife_cur = worklife_cur;
             this.workload_cur = workload_cur;
             this.careerpath_cur = careerpath_cur;
             this.td_cur = td_cur;
             this.promo_cur = promo_cur;
             this.goodsup_cur = goodsup_cur;
             this.auton_cur = auton_cur;
             this.promocrit_cur = promocrit_cur;
             this.salary_cur = salary_cur;
             this.flex_cur = flex_cur;
             this.rewperf_cur = rewperf_cur;
             this.mission_cur = mission_cur;
             this.health_cur = health_cur;
             this.rewrecog_cur = rewrecog_cur;
             this.workspace_cur = workspace_cur;
             this.poorperfs_cur = poorperfs_cur;
             this.jobsat = jobsat;
             this.commit = commit;
             this.itl = itl;
             this.values = values;
             this.jobperf = jobperf;
             this.coop = coop;
             this.help = help;
             this.court = court;
             this.cur_emp_name = cur_emp_name;
             this.cur_state = cur_state;
             this.cur_town = cur_town;
             this.curr_city_country = curr_city_country;
             this.cur_ten_years = cur_ten_years;
             this.cur_ten_mos = cur_ten_mos;
             this.hours_per_week_work = hours_per_week_work;            
             this.comments = comments;

        }

        public EmployerSurvey()
        {

        }      
    }
}
