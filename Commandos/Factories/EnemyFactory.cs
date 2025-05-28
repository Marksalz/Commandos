using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class EnemyFactory
    {
        private List<Enemy> enemies;

        public EnemyFactory() { }

        public void CreateEnemy(string name)
        {
            if (enemies == null)
            {
                enemies = new List<Enemy>();
            }
            Enemy enemy = new Enemy(name);
            enemies.Add(enemy);
            Console.WriteLine($"Enemy {name} created.");
        }
    }
}
