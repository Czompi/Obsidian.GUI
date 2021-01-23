using Obsidian.Util;
using Obsidian.Util.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;

namespace Obsidian.GUI
{
    internal class ObsidianServer
    {
        private const string globalConfigFile = "global_config.json";
        internal static readonly Dictionary<int, Server> Servers = new();

        internal static string Version => "0.1-DEV";
        internal Process Start()
        {
            Process p = new Process();
            if(Globals.Platform == OSPlatform.Windows)
                p.StartInfo.FileName = "obsidian.exe";
            else 
                p.StartInfo.FileName = "./obsidian";
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            return p;
        }

        internal async Task Cleanup()
        {
        }
    }
}