using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Enum
    {
        public enum CommandoStatus
        {
            Standing,
            Walking,
            Hiding
        }
        public enum CommandoTools
        {
            Hammer,
            Chisel,
            Rope,
            Bag,
            WaterBottle
        }
        public enum CommandoType
        {
            Regular,
            Sea,
            Air
        }
        public enum WeaponType
        {
            AK47,
            Rock
        }
    }
}
