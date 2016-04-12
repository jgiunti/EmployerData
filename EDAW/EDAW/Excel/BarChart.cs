using EDAW.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using EDAW.App.Data;
using System.Runtime.InteropServices;

namespace EDAW.ExcelSpace
{
    public class BarChart: Graph
    {
        Application _appExcel;
        public BarChart(Application app)
        {
            _appExcel = app;
        }

        public override void SetSource(double row1, double col1, double row2, double col2)
        {
            //_appExcel.ActiveChart.ChartWizard(Source: _appExcel.Range[_appExcel.Cells[row1, col1], _appExcel.Cells[row2, col2]], PlotBy: XlRowCol.xlColumns, CategoryLabels: 1, SeriesLabels: 1, HasLegend: 1, CategoryTitle: string.Empty, ValueTitle: string.Empty);

            _appExcel.ActiveChart.ChartWizard(Source: _appExcel.Range[_appExcel.Cells[row1, col1], _appExcel.Cells[row2, col2]], PlotBy: XlRowCol.xlColumns);

            _appExcel.ActiveChart.SetSourceData(_appExcel.Range[_appExcel.Cells[row1, col1], _appExcel.Cells[row2, col2]]);
        }
    }
}
