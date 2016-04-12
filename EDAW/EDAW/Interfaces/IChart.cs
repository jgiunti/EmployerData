using EDAW.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDAW.Interfaces
{
    interface IChart: IDisposable
    {
        void SetCellValue(int row, int col, object value);

        void ClearCells();

        void Close();

        void NewSheet();

        Graph NewGraph(double xpos, double ypos, double width, double height, string type = "");
    }
}
