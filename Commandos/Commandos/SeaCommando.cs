  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class SeaCommando : Commando
    {
        public SeaCommando(string name, int codeName) : base(name, codeName)
        {
        }

        public void Swimming()
        {
            Console.WriteLine("This commando can swim!");
        }

        public override void Attack()
        {
            Console.WriteLine($"Sea Commando {CodeName} is attacking.");
        }
    }
}
