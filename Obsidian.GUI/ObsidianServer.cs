using Obsidian.Util;
using Obsidian.Util.Extensions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Obsidian.GUI
{
    internal class ObsidianServer
    {
        private const string globalConfigFile = "global_config.json";
        internal static readonly Dictionary<int, Server> Servers = new();

        internal static string Version => "0.1-DEV";
        internal async Task GetConfig()
        {
            string asmpath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            //This will strip just the working path name:
            //C:\Program Files\MyApplication
            string asmdir = System.IO.Path.GetDirectoryName(asmpath);
            Environment.CurrentDirectory = asmdir;

            // Kept for consistant number parsing
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.ResetColor();
            Console.WriteLine($"A C# implementation of the Minecraft server protocol. Targeting: {Server.protocol.GetDescription()}");

            if (File.Exists(globalConfigFile))
            {
                Globals.Config = JsonSerializer.Deserialize<GlobalConfig>(File.ReadAllText(globalConfigFile));
            }
            else
            {
                Globals.Config = new GlobalConfig();
                File.WriteAllText(globalConfigFile, JsonSerializer.Serialize(Globals.Config, new JsonSerializerOptions { WriteIndented = true }));
                Console.WriteLine("Created new global configuration file");
            }

        }
        internal async Task StartServer(int serverId)
        {
            if (!(Globals.Config.ServerCount > serverId)) throw new IndexOutOfRangeException("The server id is bigger that it can possibly be.");
            string serverDir = $"Server-{serverId}";

            Directory.CreateDirectory(serverDir);

            string configPath = Path.Combine(serverDir, "config.json");
            Config config;

            if (File.Exists(configPath))
            {
                config = JsonSerializer.Deserialize<Config>(File.ReadAllText(configPath));
            }
            else
            {
                config = new Config();
                File.WriteAllText(configPath, JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true }));
                Console.WriteLine($"Created new configuration file for Server-{serverId}");
            }

            Servers.Add(serverId, new Server(config, Version, serverId));
            await Task.CompletedTask;
        }
        internal async Task Cleanup()
        {
            if (Servers.GroupBy(entry => entry.Value.Port).Any(group => group.Count() > 1))
                throw new InvalidOperationException("Multiple servers cannot be binded to the same port");

            var serverTasks = Servers.Select(entry => entry.Value.StartServerAsync());

            Console.WriteLine("Server(s) killed. Press any key to return...");
            Console.ReadKey(intercept: false);
        }
    }
}