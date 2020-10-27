using System;
using System.Windows.Forms;
using ePiggy.Forms;
using ePiggy.Forms.Auth;

namespace ePiggy
{
    public static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var handler = new Handler();
            //Application.Run(new FormMain(handler));

            Application.Run(new FormLogIn(handler));
        }
    }
}
