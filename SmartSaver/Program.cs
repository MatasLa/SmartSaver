using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataManager;

namespace SmartSaver.forms
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

            /* padaryti cia logika, kad tipo pradedam nuo start
            ir ten visi atsidarimai nuo cia, su show dialog optionais
            ir viskas yra while loope, ir pvz main'as kai issijungia ziurim, jei spaudzia log out, tai reikia grazinti i start menu
            */

            Application.Run(new FormStart());

            //200
            //


            //logika logika

        }
    }
}
