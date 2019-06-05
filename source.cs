using System;
using System.Diagnostics;

namespace SimpleWrapperLauncher
{
    static class Program
    {
        static void Main(string[] args)
        {
            try {
                Process process = Process.Start("_" + Process.GetCurrentProcess().MainModule.FileName, Process.GetCurrentProcess().StartInfo.Arguments);
                wait: process.WaitForExit();
                if (Process.GetProcessesByName(process.MainModule.FileName).Length != 0) goto wait;
            } catch (Exception e) { }
        }
    }
}
