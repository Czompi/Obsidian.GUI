using Avalonia.Controls;
using Obsidian.GUI.Views;
using Obsidian.Util;
using System.Runtime.InteropServices;

namespace Obsidian.GUI
{
    internal class Globals
    {
        public static MainWindow MainWindow { get; internal set; }
        public static ObsidianServer ObsidianServer { get; internal set; }
        public static GlobalConfig Config { get; internal set; }
        public static OSPlatform Platform
        {
            get
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    return OSPlatform.Windows;
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                    return OSPlatform.Linux;
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD))
                    return OSPlatform.FreeBSD;
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                    return OSPlatform.OSX;
                else return OSPlatform.Linux;
            }
        }
    }
}