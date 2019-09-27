using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Report
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Directory.Exists($"{Application.StartupPath}\\template"))
                Directory.CreateDirectory($"{Application.StartupPath}\\template");

            if (!File.Exists($"{Application.StartupPath}\\template\\Report.xlsx"))
                File.WriteAllBytes($"{Application.StartupPath}\\template\\Report.xlsx", Properties.Resources.Report);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormReport());
        }
    }
}
