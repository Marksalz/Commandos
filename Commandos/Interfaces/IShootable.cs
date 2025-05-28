using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal interface IShootable : IWeapon
    {
        int BulletCapacity { get; set; }
        new string Name { get; set; }
        new string Manufacturer { get; set; }
        void Shoot();
    }
}
