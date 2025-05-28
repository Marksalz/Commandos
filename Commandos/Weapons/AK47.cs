using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class AK47 : IShootable
    {
        public string Name { get; set; } = "AK47";
        public string Manufacturer { get; set; } = "Kalashnikov"; 
        public int BulletCapacity { get; set; } = 30;

        public AK47() { }

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
