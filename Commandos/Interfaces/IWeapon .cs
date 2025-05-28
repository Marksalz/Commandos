using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal interface IWeapon
    {
        string Name { get; set; }
        string Manufacturer { get; set; }
    }
}
