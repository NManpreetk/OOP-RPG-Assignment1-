using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    class Shop
    {
        public List<Armor> Armor { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<Potion> Potions { get; set; }

        public Shop()
        {
            var Armor = new List<string>();
            var Weapons = new List<string>();
            var Potions = new List<string>();
        }
    }
}
