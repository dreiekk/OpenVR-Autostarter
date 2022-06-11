using System;
using System.Threading;
using System.Windows.Forms;

namespace OpenVR_Autostarter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (checkAlreadyRunning() == true)
            {
                return;
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mf = new MainForm();
            mf.Hide();
            Application.Run();
        }

        /**
        * <see cref="https://stackoverflow.com/a/6486341/9973021"/>
        */
        static bool checkAlreadyRunning()
        {
            bool result;
            var mutex = new Mutex(true, "B90F9B8E-06B4-4FA8-931E-6EF755962734", out result);

            if (!result)
            {
                //MessageBox.Show("App is already running.");
                Application.Exit();
                return true;
            }

            GC.KeepAlive(mutex); // mutex shouldn't be released - important line
            return false;
        }
    }
}