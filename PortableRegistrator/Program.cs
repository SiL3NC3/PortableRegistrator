using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortableRegistrator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                //string[] args = Environment.GetCommandLineArgs();

                //// If no parameters given, start with admin permissions and option '-gui'
                //if ((args.Length == 1))
                //{
                //    RestartWithAdmin();
                //}
                //else
                //{
                //    var option = args[1].ToLower();
                //    if (option == "-gui")
                //    {
                //        RunGUI();
                //    }
                //    else
                //    {
                //        CLI.Run(args);
                //    }
                //}
                RunGUI();
            }
            catch (Exception ex)
            {
                SimpleLogger.Instance.Error(ex);
            }

        }

        //private static void RestartWithAdmin()
        //{
        //    WindowsPrincipal pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
        //    bool hasAdministrativeRight = pricipal.IsInRole(WindowsBuiltInRole.Administrator);
        //    if (!hasAdministrativeRight)
        //    {
        //        // relaunch the application with admin rights
        //        string fileName = Assembly.GetExecutingAssembly().Location;
        //        ProcessStartInfo processInfo = new ProcessStartInfo();
        //        processInfo.Verb = "runas";
        //        processInfo.FileName = fileName;
        //        processInfo.Arguments = "-gui";

        //        try
        //        {
        //            Process.Start(processInfo);
        //        }
        //        catch (Win32Exception)
        //        {
        //            // This will be thrown if the user cancels the prompt
        //        }
        //        return;
        //    }
        //}

        private static void RunGUI()
        {
            Console.WriteLine("Starting GUI!");
            // Start GUI
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
