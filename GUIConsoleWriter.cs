using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PortableRegistrator
{
    public class GUIConsoleWriter
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;

        public static void RegisterGUIConsoleWriter()
        {
            AttachConsole(ATTACH_PARENT_PROCESS);
        }
    }
}
