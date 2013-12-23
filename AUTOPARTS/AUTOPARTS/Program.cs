using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AUTOPARTS.DCAT.LOGIN;

namespace AUTOPARTS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //Application.Run(new MainWindow());
        }
    }
}
