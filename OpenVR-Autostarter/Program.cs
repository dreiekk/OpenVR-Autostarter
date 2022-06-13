using System;
using System.Threading;
using System.Windows.Forms;

namespace OpenVR_Autostarter
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            if (CheckAlreadyRunning() == true)
            {
                return;
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            MainForm mf = new MainForm();
            mf.Hide();
            Application.Run();
        }

        /**
        * <see cref="https://stackoverflow.com/a/6486341/9973021"/>
        */
        static bool CheckAlreadyRunning()
        {
            var mutex = new Mutex(true, "B90F9B8E-06B4-4FA8-931E-6EF755962734", out bool result);

            if (!result)
            {
                // App is already running
                Application.Exit();
                return true;
            }

            GC.KeepAlive(mutex);
            return false;
        }
    }
}