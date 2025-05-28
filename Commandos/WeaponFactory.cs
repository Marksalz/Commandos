using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class WeaponFactory
    {
        private List<Weapon> weapons;
        public WeaponFactory() { }

        public void CreateWeapon(string weaponName, string manufacturer, int bulletCapacity)
        {
            if (weapons == null)
            {
                weapons = new List<Weapon>();
            }
            weapons.Add(new Weapon(weaponName, manufacturer, bulletCapacity));
            Console.WriteLine($"Weapon {weaponName} created.");
        }
    }
}
