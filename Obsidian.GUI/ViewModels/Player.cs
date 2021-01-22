using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obsidian.GUI.ViewModels
{
    public class Player : IPlayer
    {
        public Player(string username, Guid uuid, bool is_operator)
        {
            Username = username;
            Uuid = uuid;
            IsOperator = is_operator;
        }
        public Player(string username, string uuid, bool is_operator)
        {
            Username = username;
            Uuid = Guid.Parse(uuid);
            IsOperator = is_operator;
        }
        public string Username { get; }

        public Guid Uuid { get; }

        public bool IsOperator { get; }

        public bool Sleeping { get; set; }
        public bool Sneaking { get; set; }
        public bool Sprinting { get; set; }
        public bool FlyingWithElytra { get; set; }
        public bool InHorseInventory { get; set; }
        public short AttackTime { get; set; }
        public short DeathTime { get; set; }
        public short HurtTime { get; set; }
        public short SleepTimer { get; set; }
        public short CurrentSlot { get; set; }

        public int Ping { get; }

        public int Dimension { get; set; }
        public int FoodLevel { get; set; }
        public int FoodTickTimer { get; set; }
        public int XpLevel { get; set; }
        public int XpTotal { get; set; }

        public double HeadY { get; }

        public float AdditionalHearts { get; set; }
        public float FallDistance { get; set; }
        public float FoodExhastionLevel { get; set; }
        public float FoodSaturationLevel { get; set; }
    }
}
