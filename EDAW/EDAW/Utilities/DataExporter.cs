using EDAW.ExcelSpace;
using EDAW.Interfaces;
using System.Windows.Forms;

namespace EDAW.Utilities
{
    public class DataExporter
    {
        private DataGridView _view;

        public DataExporter(DataGridView view)
        {
            _view = view;
        }

        public void Export()
        {
            int offset;
            using (IChart excel = new ExcelModel(_view.Name + " export"))
            {
                foreach (DataGridViewRow row in _view.Rows)
                {                 
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Excel is 1 based not zero, must add 1 to indexes
                        offset = row.Index == 0 ? 2 : 1;
                        if (row.Index == 0)
                        {
                            excel.SetCellValue(row.Index + 1, cell.ColumnIndex + 1, cell.OwningColumn.HeaderCell.Value);
                        }

                        excel.SetCellValue(row.Index + offset, cell.ColumnIndex + 1, cell.Value);
                    }
                }
                excel.Close();
            }
        }
    }
}
