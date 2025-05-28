using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class M16 : IShootable
    {
        public string Name { get; set; } = "M16";
        public string Manufacturer { get; set; } = "Colt";
        public int BulletCapacity { get; set; } = 29;

        public M16() { }

        public void Shoot()
        {
            if (BulletCapacity > 0)
            {
                BulletCapacity--;
                Console.WriteLine($"Shot fired! Remaining bullets: {BulletCapacity}");
            }
            else
            {
                Console.WriteLine("No bullets left to shoot!");
            }
        }
    }
}
