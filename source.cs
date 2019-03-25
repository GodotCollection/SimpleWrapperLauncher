using System;
using System.Diagnostics;
using System.IO;

namespace SimpleWrapperLauncher
{
    class SimpleWrapperLauncher
    {
        static void Main(string[] args)
        {
            try
            {
                string _this = Process.GetCurrentProcess().MainModule.FileName;
                string _path = Path.GetDirectoryName(_this) + "\\_" + Path.GetFileName(_this);
                Process.Start(_path, Process.GetCurrentProcess().StartInfo.Arguments);
                while (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(_path)).Length != 0);
            }
            catch (Exception e) { }
        }
    }
}
