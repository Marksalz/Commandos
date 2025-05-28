using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class AirCommando : Commando
    {
        public AirCommando(string name, int codeName) : base(name, codeName)
        { 
        }

        public void Parachute()
        {
            Console.WriteLine("This commando can parachute!");
        }

        public override void Attack()
        {
            Console.WriteLine($"Air Commando {CodeName} is attacking.");
        }
    }
}
