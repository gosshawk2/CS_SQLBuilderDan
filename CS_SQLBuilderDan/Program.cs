using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_SQLBuilderDan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static string Theme;
        public static string DBType;
        public static string ComputerName;
        public static string CurrentUser;
        public static string CurrentServer;
        public static string CurrentServerInstance;
        public static string CurrentDBName;
        public static string CurrentTableName;
        public static string CurrentMode;
        public static string SystemServer;
        public static string SystemServerInstance;
        public static string SystemDatabase;
        public static string SystemHeaderTable;
        public static string SystemDetailTable;
        public static IntPtr ParentHandle;
        public static Form ParentForm;
        public static Form_MAIN MainForm;
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_MAIN());
        }
    }
}
