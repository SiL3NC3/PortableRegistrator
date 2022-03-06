using Microsoft.Win32;
using PortableRegistrator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortableRegistrator.Helper
{

    public class RegistryHelper
    {
        // PUBLIC METHODS
        public static string[] GetPortableApps()
        {
            var subKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\RegisteredApplications");
            var apps = subKey.GetValueNames();
            List<string> portables = new List<string>();
            foreach (var app in apps)
            {
                if (app.ToUpper().EndsWith("PORTABLE"))
                    portables.Add(app);
            }
            return portables.ToArray();
        }
        public static List<string> Register(AppType appType, string exePath, string prgNAME)
        {
            var prgTYPE = GetProgramName(prgNAME, ProgramNameTypes.TYPE);
            var prgURL = GetProgramName(prgNAME, ProgramNameTypes.URL);

            exePath = $"\"{exePath}\"";
            var errors = new List<string>();

            try
            {
                Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\RegisteredApplications", prgNAME, $"Software\\Clients\\StartMenuInternet\\{prgNAME}\\Capabilities", RegistryValueKind.String);
                Registry.SetValue($"HKEY_LOCAL_MACHINE\\SOFTWARE\\Clients\\StartMenuInternet\\{prgNAME}\\Capabilities", "ApplicationName", prgNAME, RegistryValueKind.String);
                Registry.SetValue($"HKEY_LOCAL_MACHINE\\SOFTWARE\\Clients\\StartMenuInternet\\{prgNAME}\\Capabilities", "ApplicationDescription", "Registered with PortableRegistrator ;)", RegistryValueKind.String);
                Registry.SetValue($"HKEY_LOCAL_MACHINE\\SOFTWARE\\Clients\\StartMenuInternet\\{prgNAME}\\Capabilities", "ApplicationIcon", exePath + ",0", RegistryValueKind.String);
                Registry.SetValue($"HKEY_LOCAL_MACHINE\\SOFTWARE\\Clients\\StartMenuInternet\\{prgNAME}\\Capabilities", "Hidden", 0, RegistryValueKind.DWord);

                foreach (var fileAssoc in appType.FileAssociations)
                {
                    Registry.SetValue($"HKEY_LOCAL_MACHINE\\SOFTWARE\\Clients\\StartMenuInternet\\{prgNAME}\\Capabilities\\FileAssociations", fileAssoc, prgTYPE, RegistryValueKind.String);
                }

                Registry.SetValue($"HKEY_LOCAL_MACHINE\\SOFTWARE\\Clients\\StartMenuInternet\\{prgNAME}\\Capabilities\\StartMenu", "StartMenuInternet", prgNAME, RegistryValueKind.String);

                foreach (var urlAssoc in appType.URLAssociations)
                {
                    Registry.SetValue($"HKEY_LOCAL_MACHINE\\SOFTWARE\\Clients\\StartMenuInternet\\{prgNAME}\\Capabilities\\URLAssociations", urlAssoc, prgURL, RegistryValueKind.String);
                }

                Registry.SetValue($"HKEY_LOCAL_MACHINE\\SOFTWARE\\Clients\\StartMenuInternet\\{prgNAME}", "LocalizedString", prgNAME, RegistryValueKind.String);
                Registry.SetValue($"HKEY_LOCAL_MACHINE\\SOFTWARE\\Clients\\StartMenuInternet\\{prgNAME}", "", prgNAME, RegistryValueKind.String);
                Registry.SetValue($"HKEY_LOCAL_MACHINE\\SOFTWARE\\Clients\\StartMenuInternet\\{prgNAME}\\DefaultIcon", "", exePath + ",0", RegistryValueKind.String);
                Registry.SetValue($"HKEY_LOCAL_MACHINE\\SOFTWARE\\Clients\\StartMenuInternet\\{prgNAME}\\shell\\open\\command", "", exePath, RegistryValueKind.String);
                Registry.SetValue($"HKEY_LOCAL_MACHINE\\SOFTWARE\\Clients\\StartMenuInternet\\{prgNAME}\\shell\\properties\\command", "", exePath + $" {appType.PropertiesParameter}", RegistryValueKind.String);

                Registry.SetValue($"HKEY_CLASSES_ROOT\\{prgURL}", "", $"{prgNAME} URL", RegistryValueKind.String);
                Registry.SetValue($"HKEY_CLASSES_ROOT\\{prgURL}", "URL Protocol", "", RegistryValueKind.String);
                Registry.SetValue($"HKEY_CLASSES_ROOT\\{prgURL}\\DefaultIcon", "", exePath + ",0", RegistryValueKind.ExpandString);
                Registry.SetValue($"HKEY_CLASSES_ROOT\\{prgURL}\\shell\\open\\command", "", $"{exePath} {appType.OpenParameters}", RegistryValueKind.ExpandString);

                Registry.SetValue($"HKEY_CLASSES_ROOT\\{prgTYPE}", "", $"{prgNAME} TYPE", RegistryValueKind.String);
                Registry.SetValue($"HKEY_CLASSES_ROOT\\{prgTYPE}\\DefaultIcon", "", exePath + ",0", RegistryValueKind.String);
                Registry.SetValue($"HKEY_CLASSES_ROOT\\{prgTYPE}\\shell\\open\\command", "", $"{exePath} {appType.OpenParameters}", RegistryValueKind.String);
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message);
            }

            return errors;
        }
        public static List<string> Unregister(string prgNAME)
        {
            var prgTYPE = GetProgramName(prgNAME, ProgramNameTypes.TYPE);
            var prgURL = GetProgramName(prgNAME, ProgramNameTypes.URL);

            var errors = new List<string>();

            // Delete Registry.LocalMachine.DeleteSubKeyTree($"SOFTWARE\\Clients\\StartMenuInternet\\{prgNAME}");
            try { Registry.LocalMachine.DeleteSubKeyTree($"SOFTWARE\\Clients\\StartMenuInternet\\{prgNAME}"); }
            catch (Exception ex) { errors.Add("1: " + ex.Message); }

            // Delete Registry.LocalMachine.DeleteSubKeyTree($"SOFTWARE\\Classes\\{prgTYPE}");
            try { Registry.LocalMachine.DeleteSubKeyTree($"SOFTWARE\\Classes\\{prgTYPE}"); }
            catch (Exception ex) { errors.Add("2: " + ex.Message); }

            // Delete Registry.LocalMachine.DeleteSubKeyTree($"SOFTWARE\\Classes\\{prgURL}");
            try { Registry.LocalMachine.DeleteSubKeyTree($"SOFTWARE\\Classes\\{prgURL}"); }
            catch (Exception ex) { errors.Add("3: " + ex.Message); }

            // Delete Registry.LocalMachine.OpenSubKey("SOFTWARE\\RegisteredApplications", writable: true).DeleteValue(prgNAME);
            try { Registry.LocalMachine.OpenSubKey("SOFTWARE\\RegisteredApplications", writable: true).DeleteValue(prgNAME); }
            catch (Exception ex) { errors.Add("4: " + ex.Message); }

            return errors;
        }

        // PRIVATES
        private enum ProgramNameTypes { TYPE, URL }
        private static string GetProgramName(string prgNAME, ProgramNameTypes type)
        {
            switch (type)
            {
                case ProgramNameTypes.TYPE:
                    return prgNAME.Replace(" ", "") + type;
                case ProgramNameTypes.URL:
                    return prgNAME.Replace(" ", "") + type;
            }
            return null;
        }
    }
}
