using EDAW.Abstract;
using EDAW.Contexts;
using EDAW.ExcelSpace;
using EDAW.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EDAW.Reports
{
    public class Top10EmpValues : IReport
    {
        public void DrawReport()
        {   
            Tuple<string, double> workLife;
            Tuple<string, double> jobsec;
            Tuple<string, double> training;
            Tuple<string, double> workload;
            Tuple<string, double> careerpath;
            Tuple<string, double> promocrit;
            Tuple<string, double> promo;
            Tuple<string, double> auton;
            Tuple<string, double> salary;
            Tuple<string, double> goodSuper;
            Tuple<string, double> flex;
            Tuple<string, double> rewPerf;
            Tuple<string, double> mission;
            Tuple<string, double> health;
            Tuple<string, double> rewrecog;
            Tuple<string, double> workspace;
            Tuple<string, double> poorperfs;

            int totalExplorers = JobExplorerManager.JobExplorers.Count();

            int totalSurveys = PersonalSurveyManager.PersonalSurveys.Count();

            workLife = new Tuple<string, double>("Work Life Balance", PersonalSurveyManager.PersonalSurveys.Sum(x => x.worklife_self) / totalSurveys);
            jobsec = new Tuple<string, double>("Job Security", PersonalSurveyManager.PersonalSurveys.Sum(x => x.jobsec_self) / totalSurveys);
            training = new Tuple<string, double>("Training and Development", PersonalSurveyManager.PersonalSurveys.Sum(x => x.td_self) / totalSurveys);
            careerpath = new Tuple<string, double>("Clear Career Path", PersonalSurveyManager.PersonalSurveys.Sum(x => x.careerpath_self) / totalSurveys);
            promocrit = new Tuple<string, double>("Clear Promotion Criteria", PersonalSurveyManager.PersonalSurveys.Sum(x => x.promocrit_self) / totalSurveys);
            workload = new Tuple<string, double>("Manageable Workload", PersonalSurveyManager.PersonalSurveys.Sum(x => x.workload_self) / totalSurveys);
            promo = new Tuple<string, double>("Promotion Opportunities", PersonalSurveyManager.PersonalSurveys.Sum(x => x.promo_self) / totalSurveys);
            auton = new Tuple<string, double>("Autonomy", PersonalSurveyManager.PersonalSurveys.Sum(x => x.auton_self) / totalSurveys);
            salary = new Tuple<string, double>("High Salary", PersonalSurveyManager.PersonalSurveys.Sum(x => x.salary_self) / totalSurveys);
            goodSuper = new Tuple<string, double>("Good Supervisors", PersonalSurveyManager.PersonalSurveys.Sum(x => x.goodsup_self) / totalSurveys);
            flex = new Tuple<string, double>("Flexible Schedules", PersonalSurveyManager.PersonalSurveys.Sum(x => x.flex_self) / totalSurveys);
            rewPerf = new Tuple<string, double>("Performance Rewards", PersonalSurveyManager.PersonalSurveys.Sum(x => x.rewperf_self) / totalSurveys);
            mission = new Tuple<string, double>("A Clear Mission", PersonalSurveyManager.PersonalSurveys.Sum(x => x.mission_self) / totalSurveys);
            health = new Tuple<string, double>("Good Health Benefits", PersonalSurveyManager.PersonalSurveys.Sum(x => x.health_self) / totalSurveys);
            rewrecog = new Tuple<string, double>("Rewards and Recognition", PersonalSurveyManager.PersonalSurveys.Sum(x => x.rewrecog_self) / totalSurveys);
            workspace = new Tuple<string, double>("Private Work Space", PersonalSurveyManager.PersonalSurveys.Sum(x => x.workspace_self) / totalSurveys);
            poorperfs = new Tuple<string, double>("Deals with Poor Performance", PersonalSurveyManager.PersonalSurveys.Sum(x => x.poorperfs_self) / totalSurveys);

            List<Tuple<string, double>> critList = new List<Tuple<string, double>>();
            critList.Add(workLife);
            critList.Add(jobsec);
            critList.Add(training);
            critList.Add(workload);
            critList.Add(careerpath);
            critList.Add(promocrit);
            critList.Add(promo);
            critList.Add(auton);
            critList.Add(salary);
            critList.Add(goodSuper);
            critList.Add(flex);
            critList.Add(rewPerf);
            critList.Add(mission);
            critList.Add(health);
            critList.Add(rewrecog);
            critList.Add(workspace);
            critList.Add(poorperfs);

            using (IChart excel = new ExcelModel("Top 10 Employee Work Values"))
            {
                int idx = 1;
                foreach (Tuple<string, double> pair in critList.OrderBy(x => x.Item2).Take(10))
                {
                    excel.SetCellValue(idx, 1, pair.Item1);
                    excel.SetCellValue(idx, 2, pair.Item2);
                    idx++;
                }

                Graph newG = excel.BarChart(50, 50, 1000, 300);

                newG.SetSource(1, 1, idx-1, 2);

                excel.Close();
            }
        }
    }
}
