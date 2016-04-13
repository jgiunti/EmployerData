using System;
using EDAW.Interfaces;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using EDAW.Abstract;
using EDAW.App.Data;

namespace EDAW.ExcelSpace
{
    public class ExcelModel : IChart, IDisposable
    {
        private Application _excel;
        private string _fileName;

        public ExcelModel(string fileName)
        {
            _excel = new Application();
            _excel.SheetsInNewWorkbook = 1;
            _excel.Workbooks.Add(Type.Missing);
            _excel.Visible = false;
            _excel.ScreenUpdating = false;
            _fileName = fileName;
            _excel.ActiveWorkbook.Sheets[1].Activate();
        }

        public void SetCellValue(int row, int col, object value)
        {
            _excel.ActiveSheet.Cells[row, col].Value2 = value;
        }

        public void ClearCells()
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            if (_excel.Workbooks.Count != 0)
            {
                Save();
            }
            _excel.Quit();
        }

        private void Save()
        {
            _excel.Application.ActiveWorkbook.SaveAs(AppEnvironment.currentUser.savePath + _fileName, XlSaveAsAccessMode.xlNoChange);
        }

        public void NewSheet()
        {
            Worksheet sheet = _excel.Worksheets.Add(After: _excel.ActiveWorkbook.Worksheets[_excel.ActiveWorkbook.Worksheets.Count]);
            _excel.Worksheets[sheet.Name].Activate();
        }

        public Graph BarChart(double xpos, double ypos, double width, double height, string type = "")
        {
            _excel.ActiveSheet.ChartObjects.Add[xpos, ypos, width, height].Select();
            _excel.ActiveSheet.ChartObjects[1].Activate();
            _excel.ActiveChart.ChartType = XlChartType.xlBarClustered;
            return new BarChart(_excel);
        }

        public Graph ColumnChart(double xpos, double ypos, double width, double height, string type = "")
        {
            _excel.ActiveSheet.ChartObjects.Add[xpos, ypos, width, height].Select();
            _excel.ActiveSheet.ChartObjects[1].Activate();
            _excel.ActiveChart.ChartType = XlChartType.xlColumnClustered;
            return new BarChart(_excel);
        }

        public void Dispose()
        {
            Marshal.FinalReleaseComObject(_excel);
            _excel = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
