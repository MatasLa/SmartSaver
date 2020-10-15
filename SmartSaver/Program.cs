using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using DataManager;
using ePiggy;
using ePiggy.forms;
using ImageChartsLib;
using System.Globalization;
using DataBases;

namespace EPiggy
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 


        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var handler = new Handler();
            Application.Run(new FormMain(handler));

            //Application.Run(new FormLogIn(handler));
        }
    }
}
