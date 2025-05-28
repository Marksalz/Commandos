using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Game
    {
        private EnemyFactory enemyFactory;
        private CommandoFactory commandoFactory;
        private WeaponFactory weaponFactory;

        public Game()
        {
            enemyFactory = new EnemyFactory();
            commandoFactory = new CommandoFactory();
            weaponFactory = new WeaponFactory();
        }
        public void StartGame()
        {
            Console.WriteLine("Welcome to the Commandos Game!");
            // Initialize factories and create some commandos, enemies, and weapons
            commandoFactory.RegisterCommando("Regular", (name, codeName) => new Commando(name, codeName));
            commandoFactory.RegisterCommando("Sea", (name, codeName) => new SeaCommando(name, codeName));
            commandoFactory.RegisterCommando("Air", (name, codeName) => new AirCommando(name, codeName));

            Commando john = (Commando)commandoFactory.CreateCommando("Regular", "John", 101);
            SeaCommando sea = (SeaCommando)commandoFactory.CreateCommando("Sea", "Sam", 102);
            AirCommando air = (AirCommando)commandoFactory.CreateCommando("Air", "Alex", 103);

            john?.Attack();
            sea?.Attack();
            air?.Attack();

            enemyFactory.CreateEnemy("Enemy1");

            weaponFactory.RegisterWeapon("AK47", (name, manufacturer) => new AK47 { Name = name, Manufacturer = manufacturer });
            weaponFactory.RegisterWeapon("Rock", (name, manufacturer) => new Rock(name, manufacturer));

            AK47 aK47 = (AK47)weaponFactory.CreateWeapon("AK47", "MyAK47", "Kalashnikov");
            Rock rock = (Rock)weaponFactory.CreateWeapon("Rock", "MyRock", "Nature Inc.");
            aK47.Shoot();
            rock.Hit();
        }
    }
}
