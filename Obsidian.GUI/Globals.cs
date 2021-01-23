using Avalonia.Controls;
using Obsidian.GUI.Views;
using Obsidian.Util;

namespace Obsidian.GUI
{
    internal class Globals
    {
        public static MainWindow MainWindow { get; internal set; }
        public static ObsidianServer ObsidianServer { get; internal set; }
        public static GlobalConfig Config { get; internal set; }
    }
}