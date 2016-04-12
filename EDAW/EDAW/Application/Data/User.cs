using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDAW.App.Data
{
    public static class User
    {
        public static string saveFilePath = @"G:\Documents\ExcelTest\";

        public static void Init()
        {
            saveFilePath = String.Empty;
        }
    }
}
