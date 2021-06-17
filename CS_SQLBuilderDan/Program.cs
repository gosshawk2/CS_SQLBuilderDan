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
        public static string CurrentUser;
        public static string CurrentServer;
        public static string CurrentMode;
        public static IntPtr ParentHandle;
        public static Form ParentForm;
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_MAIN());
        }
    }
}
