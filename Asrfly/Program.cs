using Asrfly.Code;
using Asrfly.Data.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asrfly
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DependnecyInjection.AddDependencyValues();
            SqlCon.SqlConnetion = Properties.Settings.Default.SqlServerConString;
            Application.Run(new StartForm());
        }
    }
}
