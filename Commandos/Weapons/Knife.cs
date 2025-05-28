using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    enum MetalType
    {
        Steel,
        Iron
    }
    internal class Knife : IBreakable, IWeapon
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public Status Status { get; set; } = Status.Whole;
        public int MaxHits { get; set; }
        public int HitsTaken { get; set; }
        public double Weight { get; set; }
        public string Manufactrer { get; set; }
        public string Color { get; set; }
        public MetalType metalType { get; set; }

        public Knife(string name, string manufactrer)
        {
            this.Name = name;
            this.Manufactrer = manufactrer;
        }

        public void Hit()
        {
            if (Status == Status.Whole)
            {
                HitsTaken++;
                if (HitsTaken >= MaxHits)
                {
                    Status = Status.Broken;
                    Console.WriteLine($"{Name} is now broken.");
                }
                else
                {
                    Console.WriteLine($"{Name} has been hit. Hits taken: {HitsTaken}/{MaxHits}");
                }
            }
            else
            {
                Console.WriteLine($"{Name} is already broken and cannot be hit again.");
            }
        }
    }
}
