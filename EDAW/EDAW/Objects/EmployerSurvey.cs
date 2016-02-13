using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDAW.Objects
{
    public class EmployerSurvey
    {
        public ObjectId id;

        public int cur_or_form;
        public int jobsec_cur;
        public int worklife_cur;
        public int workload_cur;
        public int careerpath_cur;
        public int td_cur;
        public int promo_cur;
        public int goodsup_cur;
        public int auton_cur;
        public int promocrit_cur;
        public int salary_cur;
        public int flex_cur;
        public int rewperf_cur;
        public int mission_cur;
        public int health_cur;
        public int rewrecog_cur;
        public int workspace_cur;
        public int poorperfs_cur;
        public int careless1;
        public int jobsat;
        public int commit;
        public int itl;
        public int careless2;
        public int values;
        public int jobperf;
        public int coop;
        public int help;
        public int court;
        public string cur_emp_name;
        public int cur_state;
        public string cur_town;
        public string curr_city_country;
        public string cur_ten_years;
        public int cur_ten_mos;
        public int hours_per_week_work;
        public int jobsec_for;
        public int workload_for;
        public int worklife_for;
        public int careerpath_for;
        public int td_for;
        public int goodsup_for;
        public int promo_for;
        public int auton_for;
        public int promocrit_for;
        public int salary_for;
        public int flex_for;
        public int rewperf_for;
        public int mission_for;
        public int health_for;
        public int rewrecog_for;
        public int workspace_for;
        public int poorperfs_for;
        public string for_emp_name;
        public string for_state;
        public string for_town;
        public string curr_city_country_intl;
        public int for_sepyear;
        public string for_ten_years;
        public int for_ten_mos;
        public string for_leave_choice;
        public int hours_per_week2;
        public string comments;
        public string timeStamp;

        public EmployerSurvey(int cur_or_form, int jobsec_cur, int worklife_cur, int workload_cur, int careerpath_cur, int td_cur, int promo_cur, int goodsup_cur, int auton_cur, int promocrit_cur,
            int salary_cur, int flex_cur, int rewperf_cur, int mission_cur, int health_cur, int rewrecog_cur, int workspace_cur, int poorperfs_cur, int careless1, int jobsat, int commit,
            int itl, int careless2, int values, int jobperf, int coop, int help, int court, string cur_emp_name, int cur_state, string cur_town, string curr_city_country, string cur_ten_years,
            int cur_ten_mos, int hours_per_week_work, int jobsec_for, int workload_for, int worklife_for, int careerpath_for, int td_for, int goodsup_for, int promo_for, int auton_for, int promocrit_for,
            int salary_for, int flex_for, int rewperf_for, int mission_for, int health_for, int rewrecog_for, int workspace_for, int poorperfs_for, string  for_emp_name, string for_state,
            string for_town, string curr_city_country_intl, int for_sepyear, string for_ten_years, int for_ten_mos, string for_leave_choice, int hours_per_week2, string comments, string timeStamp)
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
             this.careless1 = careless1;
             this.jobsat = jobsat;
             this.commit = commit;
             this.itl = itl;
             this.careless2 = careless2;
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
             this.jobsec_for = jobsec_for;
             this.workload_for = workload_for;
             this.worklife_for = worklife_for;
             this.careerpath_for = careerpath_for;
             this.td_for = td_for;
             this.goodsup_for = goodsup_for;
             this.promo_for = promo_for;
             this.auton_for = auton_for;
             this.promocrit_for = promocrit_for;
             this.salary_for = salary_for;
             this.flex_for = flex_for;
             this.rewperf_for = rewperf_for;
             this.mission_for = mission_for;
             this.health_for = health_for;
             this.rewrecog_for = rewrecog_for;
             this.workspace_for = workspace_for;
             this.poorperfs_for = poorperfs_for;
             this.for_emp_name = for_emp_name;
             this.for_state = for_state;
             this.for_town = for_town;
             this.curr_city_country_intl = curr_city_country_intl;
             this.for_sepyear = for_sepyear;
             this.for_ten_years = for_ten_years;
             this.for_ten_mos = for_ten_mos;
             this.for_leave_choice = for_leave_choice;
             this.hours_per_week2 = hours_per_week2;
             this.comments = comments;

        }

        public EmployerSurvey()
        {

        }      
    }
}
