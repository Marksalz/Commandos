using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Weapon
    {
        string name;
        string manufacturer;
        int bulletCapacity;

        public Weapon(string name, string manufacturer, int bulletCapacity)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.bulletCapacity = bulletCapacity;
        }

        public void Shoot()
        {
            Console.WriteLine($"{name} is shooting.");
            this.bulletCapacity--;
        }
    }
}
