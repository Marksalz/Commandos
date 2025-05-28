using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class CommandoFactory
    {
        private List<Commando> commandos;
        public CommandoFactory() { }
        public void CreateCommando(string name, int codeName)
        {
            Commando commando = new Commando(name, codeName);
            commandos.Add(commando);
            Console.WriteLine($"Commando {name} with code name {codeName} created.");
        }
        
    }
}
