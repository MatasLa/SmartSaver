using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DataManager;
using Forms;
using Utilities;

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

            Handler dataHandler = new Handler();
            Application.Run(new FormMain(dataHandler));
            //Application.Run(new FormLogIn(dataHandler));
        }
    }
}
