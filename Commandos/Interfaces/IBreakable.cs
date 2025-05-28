using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    enum Status
    {
        Whole,
        Broken
    }
    internal interface IBreakable : IWeapon
    {
        new string Name { get; set; }
        new string Manufacturer { get; set; }
        Status Status { get; set; }
        int MaxHits { get; set; }
        int HitsTaken { get; set; }
        double Weight { get; set; }
        string Color { get; set; }
        void Hit();
    }
}
