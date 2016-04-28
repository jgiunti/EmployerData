using EDAW.Abstract;
using EDAW.Data;
using EDAW.ExcelSpace;
using EDAW.Interfaces;
using EDAW.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDAW.Reports
{
    public class EmpMismatch : IReport
    {
        private List<PersonalSurvey> _plist;
        private Employer _employer;

        public EmpMismatch(List<PersonalSurvey> plist, Employer employer)
        {
            _plist = plist;
            _employer = employer;
        }

        public void DrawReport()
        {
            int surveyCnt = _plist.Count;
            int jobsec = 0;
            int wrklife = 0;
            int wrkload = 0;
            int careerpth = 0;
            int td = 0;
            int promo = 0;
            int goodsup = 0;
            int auton = 0;
            int promocrit = 0;
            int salary = 0;
            int flex = 0;
            int rewperf = 0;
            int mission = 0;
            int health = 0;
            int rewrecog = 0;
            int wrkspc = 0;
            int poorperfs = 0;

            foreach (PersonalSurvey survey in _plist)
            {
                jobsec += survey.jobsec_self;
                wrklife += survey.worklife_self;
                wrkload += survey.workload_self;
                careerpth += survey.careerpath_self;
                td += survey.td_self;
                promo += survey.promo_self;
                goodsup += survey.goodsup_self;
                auton += survey.auton_self;
                promocrit += survey.promo_self;
                salary += survey.salary_self;
                flex += survey.flex_self;
                rewperf += survey.rewperf_self;
                mission += survey.mission_self;
                health += survey.health_self;
                rewrecog += survey.rewrecog_self;
                wrkspc += survey.workspace_self;
                poorperfs += survey.poorperfs_self;
            }

            jobsec /= surveyCnt;
            wrklife /= surveyCnt;
            wrkload /= surveyCnt;
            careerpth /= surveyCnt;
            td /= surveyCnt;
            promo /= surveyCnt;
            goodsup /= surveyCnt;
            auton /= surveyCnt;
            promocrit /= surveyCnt;
            salary /= surveyCnt;
            flex /= surveyCnt;
            rewperf /= surveyCnt;
            mission /= surveyCnt;
            health /= surveyCnt;
            rewrecog /= surveyCnt;
            wrkspc /= surveyCnt;
            poorperfs /= surveyCnt;

            using (IChart excel = new ExcelModel("Employers Mismatch vs " + _employer.employerName))
            {
                int row = 1;
                int col = 1;
                int diff = 0;
                int total = 0;
                excel.SetCellValue(row + 1, col, "Employee");
                excel.SetCellValue(row + 2, col++, _employer.employerName);

                diff = Math.Abs(jobsec - _employer.jobsec);
                excel.SetCellValue(row, col, "Job security");
                excel.SetCellValue(row + 3, col, "Job security");
                excel.SetCellValue(row + 4, col, diff);
                excel.SetCellValue(row + 1, col, jobsec);
                excel.SetCellValue(row + 2, col++, _employer.jobsec);

                total += diff;

                diff = Math.Abs(wrklife - _employer.worklife);
                excel.SetCellValue(row, col, "Work-life balance");
                excel.SetCellValue(row + 3, col, "Work-life balance");
                excel.SetCellValue(row + 4, col, diff);
                excel.SetCellValue(row + 1, col, wrklife);
                excel.SetCellValue(row + 2, col++, _employer.worklife);

                total += diff;

                diff = Math.Abs(wrkload - _employer.workload);
                excel.SetCellValue(row, col, "A manageable workload");
                excel.SetCellValue(row + 3, col, "A manageable workload");
                excel.SetCellValue(row + 4, col, diff);

                excel.SetCellValue(row + 1, col, wrkload);
                excel.SetCellValue(row + 2, col++, _employer.workload);

                total += diff;

                diff = Math.Abs(careerpth - _employer.careerpath);
                excel.SetCellValue(row, col, "A clear career path");
                excel.SetCellValue(row + 3, col, "A clear career path");
                excel.SetCellValue(row + 4, col, diff);

                excel.SetCellValue(row + 1, col, careerpth);
                excel.SetCellValue(row + 2, col++, _employer.careerpath);

                total += diff;

                diff = Math.Abs(td - _employer.td);
                excel.SetCellValue(row, col, "Providing training and development");
                excel.SetCellValue(row + 3, col, "Providing training and development");
                excel.SetCellValue(row + 4, col, diff);

                excel.SetCellValue(row + 1, col, td);
                excel.SetCellValue(row + 2, col++, _employer.td);

                total += diff;

                diff = Math.Abs(promo - _employer.promo);
                excel.SetCellValue(row, col, "Opportunities for promotion");
                excel.SetCellValue(row + 3, col, "Opportunities for promotion");
                excel.SetCellValue(row + 4, col, diff);

                excel.SetCellValue(row + 1, col, promo);
                excel.SetCellValue(row + 2, col++, _employer.promo);

                total += diff;

                diff = Math.Abs(goodsup - _employer.goodsup);
                excel.SetCellValue(row, col, "Good supervisors");
                excel.SetCellValue(row + 3, col, "Good supervisors");
                excel.SetCellValue(row + 4, col, diff);

                excel.SetCellValue(row + 1, col, goodsup);
                excel.SetCellValue(row + 2, col++, _employer.goodsup);

                total += diff;

                diff = Math.Abs(auton - _employer.auton);
                excel.SetCellValue(row, col, "Autonomy");
                excel.SetCellValue(row + 3, col, "Autonomy");
                excel.SetCellValue(row + 4, col, diff);

                excel.SetCellValue(row + 1, col, auton);
                excel.SetCellValue(row + 2, col++, _employer.auton);

                total += diff;

                diff = Math.Abs(promocrit - _employer.promocrit);
                excel.SetCellValue(row, col, "Clear promotion criteria");
                excel.SetCellValue(row + 3, col, "Clear promotion criteria");
                excel.SetCellValue(row + 4, col, diff);

                excel.SetCellValue(row + 1, col, promocrit);
                excel.SetCellValue(row + 2, col++, _employer.promocrit);

                total += diff;

                diff = Math.Abs(salary - _employer.salary);
                excel.SetCellValue(row, col, "High salary");
                excel.SetCellValue(row + 3, col, "High salary");
                excel.SetCellValue(row + 4, col, diff);

                excel.SetCellValue(row + 1, col, salary);
                excel.SetCellValue(row + 2, col++, _employer.salary);

                total += diff;

                diff = Math.Abs(flex - _employer.flex);
                excel.SetCellValue(row, col, "Flexibility");
                excel.SetCellValue(row + 3, col, "Flexibility");
                excel.SetCellValue(row + 4, col, diff);

                excel.SetCellValue(row + 1, col, flex);
                excel.SetCellValue(row + 2, col++, _employer.flex);

                total += diff;

                diff = Math.Abs(rewperf - _employer.rewperf);
                excel.SetCellValue(row, col, "Rewards performance");
                excel.SetCellValue(row + 3, col, "Rewards performance");
                excel.SetCellValue(row + 4, col, diff);

                excel.SetCellValue(row + 1, col, rewperf);
                excel.SetCellValue(row + 2, col++, _employer.rewperf);

                total += diff;

                diff = Math.Abs(mission - _employer.mission);
                excel.SetCellValue(row, col, "A clear mission");
                excel.SetCellValue(row + 3, col, "A clear mission");
                excel.SetCellValue(row + 4, col, diff);

                excel.SetCellValue(row + 1, col, mission);
                excel.SetCellValue(row + 2, col++, _employer.mission);

                total += diff;

                diff = Math.Abs(health - _employer.health);
                excel.SetCellValue(row, col, "Good health benefits");
                excel.SetCellValue(row + 3, col, "Good health benefits");
                excel.SetCellValue(row + 4, col, diff);

                excel.SetCellValue(row + 1, col, health);
                excel.SetCellValue(row + 2, col++, _employer.health);

                total += diff;

                diff = Math.Abs(rewrecog - _employer.rewrecog);
                excel.SetCellValue(row, col, "Provides rewards and recognition");
                excel.SetCellValue(row + 3, col, "Provides rewards and recognition");
                excel.SetCellValue(row + 4, col, diff);

                excel.SetCellValue(row + 1, col, rewrecog);
                excel.SetCellValue(row + 2, col++, _employer.rewrecog);

                total += diff;

                diff = Math.Abs(wrkspc - _employer.workspace);
                excel.SetCellValue(row, col, "Private office or work space");
                excel.SetCellValue(row + 3, col, "Private office or work space");
                excel.SetCellValue(row + 4, col, diff);

                excel.SetCellValue(row + 1, col, wrkspc);
                excel.SetCellValue(row + 2, col++, _employer.workspace);

                total += diff;

                diff = Math.Abs(poorperfs - _employer.poorperfs);
                excel.SetCellValue(row, col, "takes actions against poor performers");
                excel.SetCellValue(row + 3, col, "takes actions against poor performers");
                excel.SetCellValue(row + 4, col, diff);

                excel.SetCellValue(row + 1, col, poorperfs);
                excel.SetCellValue(row + 2, col++, _employer.poorperfs);

                excel.SetCellValue(row + 3, col, "Total Mismatch");
                excel.SetCellValue(row + 4, col, total);


                Graph colChart = excel.BarChart(50, 50, 500, 750);

                colChart.SetSource(1, 1, 3, 18);

                colChart.SetTitle("Employer Mismatch vs " + _employer.employerName);

                Graph mismatch = excel.ColumnChart(600, 50, 750, 500);

                mismatch.SetSource(4, 2, 5, 19);

                mismatch.SetTitle("Total Mismatch vs " + _employer.employerName);

                excel.Close();
            }
        }
    }
}
