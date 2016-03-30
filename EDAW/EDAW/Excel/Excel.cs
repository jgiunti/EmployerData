using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDAW.Interfaces;
using Microsoft.Office.Interop.Excel;
using EDAW.App.Data;

namespace EDAW.Excel
{
    public class Excel : IChart
    {
        private Application _excel;
        private string _fileName;

        public Excel(string fileName)
        {
            _excel = new Application();
            _fileName = fileName;
        }

        public void SetCellValue(int row, int col, object value)
        {
            throw new NotImplementedException();
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
            _excel.Application.ActiveWorkbook.SaveAs(User.saveFilePath + "\\" + _fileName, XlSaveAsAccessMode.xlNoChange);
        }
    }
}
