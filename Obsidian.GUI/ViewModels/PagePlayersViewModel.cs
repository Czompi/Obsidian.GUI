using Obsidian.GUI.Models;
using System;
using System.Collections.Generic;

namespace Obsidian.GUI.ViewModels
{
    public class PagePlayersViewModel : ViewModelBase
    {
        public List<IPlayer> PlayerList { get; internal set; } = new List<IPlayer>
        {
            new Player("Czompi", "1f006b39b72a4304a16c2b85b08d5b53", true),
            new Player("PandaGamer69", "e00a41515dab4244b2c65f15a3866b93", false)
        };

    }
}
