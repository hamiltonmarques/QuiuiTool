using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace QuiuiApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SingleInstanceApplication.Run(new FormQuiui(), NewInstanceHandler);
        }

        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        public static void NewInstanceHandler(object sender, StartupNextInstanceEventArgs e)
        {
            e.BringToForeground = true;
        }

        public class SingleInstanceApplication : WindowsFormsApplicationBase
        {
            private SingleInstanceApplication()
            {
                base.IsSingleInstance = true;
            }

            public static void Run(Form frm, StartupNextInstanceEventHandler startupHandler)
            {
                SingleInstanceApplication app = new SingleInstanceApplication();
                app.MainForm = frm;
                app.StartupNextInstance += startupHandler;
                app.Run(Environment.GetCommandLineArgs());
            }
        }
    }
}