using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Commandos
{
    internal class WeaponFactory
    {
        
        private Dictionary<string, Func<string, string, IWeapon>> weaponCreators;

        /// <summary>
        /// this constructor initializes the weapon factory with an empty dictionary of weapon creators.
        /// </summary>
        public WeaponFactory()
        {
            weaponCreators = new Dictionary<string, Func<string, string, IWeapon>>();
        }

        /// <summary>
        /// this method registers a weapon type with its corresponding creator function.
        /// </summary>
        /// <param name="weaponType"></param>
        /// <param name="creator"></param>
        public void RegisterWeapon(string weaponType, Func<string, string, IWeapon> creator)
        {
            if (!weaponCreators.ContainsKey(weaponType))
            {
                weaponCreators[weaponType] = creator;
            }
            else
            {
                Console.WriteLine($"Weapon type {weaponType} is already registered.");
            }
        }

        /// <summary>
        /// This method creates a weapon of the specified type.
        /// </summary>
        /// <param name="weaponType"></param>
        /// <returns></returns>
        public IWeapon CreateWeapon(string weaponType, string name, string manufacturer)
        {
            if (weaponCreators.ContainsKey(weaponType))
            {
                return weaponCreators[weaponType](name, manufacturer);
            }
            else
            {
                Console.WriteLine($"Weapon type {weaponType} is not registered.");
                return null;
            }
        }



    }
}
