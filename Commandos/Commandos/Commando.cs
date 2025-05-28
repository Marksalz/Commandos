using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Commando
    {
        enum CommandoStatus
        {
            Standing,
            Walking,
            Hiding
        }

        enum CommandoTools
        {
            Hammer,
            Chisel,
            Rope,
            Bag,
            WaterBottle
        }

        private string Name { get; set; } // Name of the commando
        private int codeName {get; set; } // Code name as an integer
        private CommandoTools[] tools = { CommandoTools.Hammer, CommandoTools.WaterBottle, CommandoTools.Chisel,
        CommandoTools.Bag, CommandoTools.Rope}; // Array to hold tools
        private CommandoStatus status = CommandoStatus.Standing; // Default status


        public Commando(string name, int codeName)
        {
            this.Name = name;
            this.codeName = codeName;
        }

        public string CodeName
        {
            get { return codeName.ToString(); }
            set
            {
                if (int.TryParse(value, out int code))
                {
                    codeName = code;
                }
                else
                {
                    throw new ArgumentException("Code name must be a number.");
                }
            }
        }

        public void Walk()
        {
            Console.WriteLine("Commando is walking.");
            this.status = CommandoStatus.Walking;
        }

        public void Hide()
        {
            Console.WriteLine("Commando is hiding.");
            this.status = CommandoStatus.Hiding;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"Commando {this.codeName} is attacking.");
        }

        public string SayName(string commanderRank)
        {
            if (commanderRank.ToLower() == "general")
            {
                return Name;
            }
            else if (commanderRank.ToLower() == "colonel")
            {
                return CodeName;
            }
            else
            {
                return "Cannot pass secret information!";
            }
        }
    }
}
