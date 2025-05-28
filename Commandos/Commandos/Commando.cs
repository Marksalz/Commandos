using System;

namespace Commandos
{
    internal class Commando : ICommando
    {
        public string Name { get; set; }
        public int CodeName { get; set; }

        //enum CommandoStatus { Standing, Walking, Hiding }
        //enum CommandoTools { Hammer, Chisel, Rope, Bag, WaterBottle }

        private Enum.CommandoTools[] tools = { Enum.CommandoTools.Hammer, Enum.CommandoTools.WaterBottle, Enum.CommandoTools.Chisel, Enum.  CommandoTools.Bag, Enum.CommandoTools.Rope };
        private Enum.CommandoStatus status = Enum.CommandoStatus.Standing;

        public Commando(string name, int codeName)
        {
            this.Name = name;
            this.CodeName = codeName;
        }

        public void Walk()
        {
            Console.WriteLine("Commando is walking.");
            this.status = Enum.CommandoStatus.Walking;
        }

        public void Hide()
        {
            Console.WriteLine("Commando is hiding.");
            this.status = Enum.CommandoStatus.Hiding;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"Commando {this.CodeName} is attacking.");
        }

        public string SayName(string commanderRank)
        {
            if (commanderRank.ToLower() == "general")
                return Name;
            else if (commanderRank.ToLower() == "colonel")
                return CodeName.ToString();
            else
                return "Cannot pass secret information!";
        }
    }
}
