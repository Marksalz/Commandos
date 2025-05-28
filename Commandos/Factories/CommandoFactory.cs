using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class CommandoFactory
    {
        public enum CommandoType
        {
            Regular,
            Sea,
            Air
        }
        private List<Commando> commandos = new List<Commando>();
        public CommandoFactory() { }

        public void CreateCommando(string name, int codeName, CommandoType commandoType)
        {
            switch(commandoType)
            {
                case CommandoType.Regular:
                    Commando regularCommando = new Commando(name, codeName);
                    commandos.Add(regularCommando);
                    break;
                case CommandoType.Sea:
                    SeaCommando seaCommando = new SeaCommando(name, codeName);
                    commandos.Add(seaCommando);
                    break;
                case CommandoType.Air:
                    AirCommando airCommando = new AirCommando(name, codeName);
                    commandos.Add(airCommando);
                    break;
                default:
                    Console.WriteLine("Invalid commando type.");
                    return;
            }
            Console.WriteLine($"Commando {name} with code name {codeName} created.");
        }
        
    }
}
