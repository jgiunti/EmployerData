using System;
using EDAW.Abstract;
using Microsoft.Office.Interop.Excel;

namespace EDAW.ExcelSpace
{
    public class BarChart: Graph
    {
        Application _appExcel;
        public BarChart(Application app)
        {
            _appExcel = app;
        }

        public override void SetSource(double row1, double col1, double row2, double col2, string plotby = "")
        {
            //_appExcel.ActiveChart.ChartWizard(Source: _appExcel.Range[_appExcel.Cells[row1, col1], _appExcel.Cells[row2, col2]], PlotBy: XlRowCol.xlColumns, CategoryLabels: 1, SeriesLabels: 1, HasLegend: 1, CategoryTitle: string.Empty, ValueTitle: string.Empty);

            XlRowCol plot;
            if (plotby.Equals("Col"))
            {
                plot = XlRowCol.xlColumns;
            }
            else
            {
                plot = XlRowCol.xlRows;
            }

            _appExcel.ActiveChart.ChartWizard(Source: _appExcel.Range[_appExcel.Cells[row1, col1], _appExcel.Cells[row2, col2]], PlotBy: plot);

            _appExcel.ActiveChart.SetSourceData(_appExcel.Range[_appExcel.Cells[row1, col1], _appExcel.Cells[row2, col2]]);
        }

        public override void SetTitle(string title)
        {
            _appExcel.ActiveChart.ChartWizard(Title: title);
        }
    }
}
