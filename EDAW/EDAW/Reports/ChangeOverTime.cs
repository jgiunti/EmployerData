using EDAW.Abstract;
using EDAW.ExcelSpace;
using EDAW.Interfaces;
using EDAW.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EDAW.Reports
{
    public class ChangeOverTime : IReport
    {
        private List<PersonalSurvey> _surveys;

        public ChangeOverTime(List<PersonalSurvey> survey)
        {
            _surveys = survey;
        }

        public void DrawReport()
        {
            using (IChart excel = new ExcelModel("Change in Survey Reponses"))
            {
                int col = 1;
                int row = 1;
                PropertyInfo[] properties = typeof(PersonalSurvey).GetProperties();
                foreach (var property in properties)
                {
                    excel.SetCellValue(row, col++, property.Name);
                }
                col = 1;
                row = 2;
                foreach (PersonalSurvey survey in _surveys)
                {
                    System.Diagnostics.Debug.WriteLine(survey.timeStamp);
                    foreach (var property in properties)
                    {
                        var value = typeof(PersonalSurvey).GetProperty(property.Name).GetValue(survey);
                        excel.SetCellValue(row, col++, value);
                        System.Diagnostics.Debug.WriteLine(property.Name + ": " + value);
                    }
                    row++;
                    col = 1;
                }
                Graph colChart = excel.ColumnChart(50, 50, 1000, 300);

                colChart.SetSource(1, 1, _surveys.Count + 1, properties.Count());

                excel.Close();
            }
        }
    }
}
