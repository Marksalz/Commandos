using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando commando = new Commando("John", 007);
            AirCommando airCommando = new AirCommando("Men", 010);
            SeaCommando seaCommando = new SeaCommando("Yoni", 011);
            Commando[] commandos = { commando, airCommando, seaCommando };
            foreach (Commando commando1 in commandos)
            {
                commando1.Attack();
            }
        }
    }
}
