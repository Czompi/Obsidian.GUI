using Obsidian.GUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obsidian.GUI.ViewModels
{
    public class ServerViewViewModel : ViewModelBase
    {
        public PagePlayersViewModel PagePlayersViewModel { get; internal set; } = new PagePlayersViewModel
        {
            PlayerList = new List<IPlayer>
        {
            new Player("PandaGamer69", "e00a41515dab4244b2c65f15a3866b93", false),
            new Player("Czompi", "1f006b39b72a4304a16c2b85b08d5b53", true)
        }
        };
        public PageConsoleViewModel PageConsoleViewModel { get; internal set; } = new PageConsoleViewModel
        {
            Log = "Hello there o/"
        };
    }
}
