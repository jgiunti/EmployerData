using EDAW.Data;
using System;

namespace EDAW.App.Data
{
    public static class Environment
    {
        public static string saveFilePath = @"G:\Documents\ExcelTest\";

        public static User currentUser; 

        public static void Init()
        {
            saveFilePath = String.Empty;
        }
    }
}
