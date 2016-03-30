using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDAW.Interfaces
{
    interface IChart
    {
        void SetCellValue(int row, int col, object value);

        void ClearCells();

        void Close();
    }
}
