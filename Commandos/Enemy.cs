using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Enemy
    {
        enum LifeStatus
        {
            Alive,
            Dead
        }

        private string name;
        private int life = 100;
        private LifeStatus status = LifeStatus.Alive; // Default status

        public Enemy(string name)
        {
            this.name = name;
        }

        public void Scream()
        {
            Console.WriteLine($"{this.name} is screaming!");
        }

    }
}
