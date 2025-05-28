using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Rock : IBreakable
    {

        public Status Status { get; set; } = Status.Whole;
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int MaxHits { get; set; } = 5;
        public int HitsTaken { get; set; } = 0;
        public double Weight { get; set; }
        public string Color { get; set; }

        public Rock(string name, string manufacturer)
        {
            Name = name;
            Manufacturer = manufacturer;
        }

        public void Hit()
        {
            if (Status == Status.Whole)
            {
                HitsTaken++;
                Console.WriteLine($"Rock hit! Hits taken: {HitsTaken}/{MaxHits}");
                if (HitsTaken >= MaxHits)
                {
                    Status = Status.Broken;
                    Console.WriteLine("The rock is now broken.");
                }
            }
            else
            {
                Console.WriteLine("The rock is already broken.");
            }
        }
    }
}
