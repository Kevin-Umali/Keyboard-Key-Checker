using System;
using System.Windows.Forms;

namespace Keyboard_Tester
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            using (new Classes.AppSingleInstance(1000)) //1000ms timeout on global lock
            {
                //Only 1 of these runs at a time
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Keyboard());
            }
        }
    }
}
