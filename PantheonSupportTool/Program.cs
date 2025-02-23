using System;
using System.Windows.Forms;

namespace PantheonSupportTool
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        internal static class AppInfo
        {
            public const string Version = "0.3.0";
        }
    }
}
