using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    public class Shop
    {
        public Game game;

        public List<Armor> Armor { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<Potion> Potions { get; set; }
        public string OriginalValue { get; set; }
        public int i { get; set; }
        public Hero hero { get; set; }

        public Shop(Hero hero, Game game)
        {
            Weapons = new List<Weapon> {
                new Weapon("Sword", 3, 2, 10), new Weapon("Axe", 4, 3, 12), new Weapon("Longsword", 7, 5, 20)
            };

            Armor = new List<Armor>{
                new Armor("Wooden Armor", 3, 2, 10), new Armor("Metal Armor", 7, 5, 20)
            };

            Potions = new List<Potion>{
                new Potion(5, "Healing Potion", 10, 6)
            };

            this.hero = hero;
            this.game = game;
        }

        public void Menu()
        {
            Console.WriteLine("Welcome to my shop! What would you like to do?");
            Console.WriteLine("a) Buy Item");
            Console.WriteLine("b) Sell Item");
            Console.WriteLine("c) Return to Game Menu");
            var input = Console.ReadLine();
            if (input == "a")
            {
                this.ShowInventory();
            }
            else if (input == "b")
            {
                this.BuyfromUser();
            }
            else
            {
                return;
            }
        }

        public void ShowInventory()
        {
            Console.WriteLine("1. Weapons");
            Console.WriteLine("2. Armor");
            Console.WriteLine("3. potion");
            var input = Console.ReadLine();
            if (input == "1")
            {
                var counter = 1;
                Console.WriteLine("*****SHOP FOR WEAPONS*****");
                for (i = 0; i < this.Weapons.Count(); i++)
                {
                    Console.WriteLine(counter + " " + this.Weapons[i].Name + " with original value of " + +this.Weapons[i].OriginalValue);
                    counter++;
                }
                Console.WriteLine("Please enter number");
                var conversionResult = int.TryParse(Console.ReadLine(), out int result);
                if (conversionResult)
                {
                    Console.WriteLine("You choose: " + Weapons[result - 1].Name);
                    this.Sell(result, input, hero);
                }
                else
                {
                    Console.WriteLine("Enter any key return to menu");
                    return;
                }
            }
            else if (input == "2")
            {
                var counter = 1;
                Console.WriteLine("*****SHOP FOR ARMORS*****");
                for (i = 0; i < this.Armor.Count(); i++)
                {
                    Console.WriteLine(counter + " " + this.Armor[i].Name + " with original value of " + +this.Armor[i].OriginalValue);
                    counter++;
                }
                Console.WriteLine("Please enter number");
                var conversionResult = int.TryParse(Console.ReadLine(), out int result);
                if (conversionResult)
                {
                    Console.WriteLine("You choose: " + Armor[result - 1].Name);
                    this.Sell(result, input, hero);
                }
                else
                {
                    Console.WriteLine("Enter any key return to menu");
                    return;
                }
            }
            else if (input == "3")
            {
                var counter = 1;
                Console.WriteLine("*****SHOP FOR POTIONS*****");
                for (i = 0; i < this.Potions.Count(); i++)
                {
                    Console.WriteLine(counter + " " + this.Potions[i].name + " with original value of " + +this.Potions[i].OriginalValue);
                    counter++;
                }
                Console.WriteLine("Please enter number");
                var conversionResult = int.TryParse(Console.ReadLine(), out int result);
                if (conversionResult)
                {
                    Console.WriteLine("You choose: " + Potions[result - 1].name);
                    this.Sell(result, input, hero);
                }
                else
                {
                    Console.WriteLine("Enter any key return to menu");
                    return;
                }
            }
            else
            {
                return;
            }
        }

        public void Sell(int result, string name,Hero hero)
        {
            if(name == "1") {
                Console.WriteLine("Weapon is a " + Weapons[result - 1].Name + " of original value " + Weapons[result - 1].OriginalValue);
                //this.hero.Gold = this.hero.Gold - this.hero.WeaponsBag[result - 1].OriginalValue;
                this.hero.WeaponsBag.Add(Weapons[result - 1]);
                foreach (var item in hero.WeaponsBag)
                {
                    Console.WriteLine(item.Name);
                }
            }
            if(name == "2")
            {
                Console.WriteLine("Armor is a " + Armor[result - 1].Name + " of original value " + Armor[result - 1].OriginalValue);
                //this.hero.Gold = this.hero.Gold - this.hero.ArmorsBag[result - 1].OriginalValue;
                hero.ArmorsBag.Add(Armor[result - 1]);
                foreach (var item in hero.ArmorsBag)
                {
                    Console.WriteLine(item.Name);
                }
            }
            if(name == "3")
            {
                Console.WriteLine("Potion is a " + Potions[result - 1].name + " of original value " + Potions[result - 1].OriginalValue);
            }
        }

        public void BuyfromUser()
        {
            Console.WriteLine("1. Weapons");
            Console.WriteLine("2. Armor");
            Console.WriteLine("3. potion");
            var input = Console.ReadLine();
            if (input == "1")
            {
                var counter = 1;
                Console.WriteLine("*****SELL WEAPONS*****");
                for (i = 0; i < this.Weapons.Count(); i++)
                {
                    Console.WriteLine(counter + " " + this.Weapons[i].Name + " with resell value of " + +this.Weapons[i].ResellValue);
                    counter++;
                }
                Console.WriteLine("Please enter number");
                var conversionResult = int.TryParse(Console.ReadLine(), out int result);
                if (conversionResult)
                {
                    Console.WriteLine("You choose: " + Weapons[result - 1].Name);
                    this.SellFromUser(result, input);
                }
                else
                {
                    Console.WriteLine("Enter any key return to menu");
                    return;
                }
            }
            else if (input == "2")
            {
                var counter = 1;
                Console.WriteLine("*****SELL ARMORS*****");
                for (i = 0; i < this.Armor.Count(); i++)
                {
                    Console.WriteLine(counter + " " + this.Armor[i].Name + " with resell value of " +this.Armor[i].ResellValue);
                    counter++;
                }
                Console.WriteLine("Please enter number");
                var conversionResult = int.TryParse(Console.ReadLine(), out int result);
                if (conversionResult)
                {
                    Console.WriteLine("You choose: " + Armor[result - 1].Name);
                    this.Sell(result, input, hero);
                }
                else
                {
                    Console.WriteLine("Enter any key return to menu");
                    return;
                }
            }
            else if (input == "3")
            {
                var counter = 1;
                Console.WriteLine("*****SELL POTIONS*****");
                for (i = 0; i < this.Potions.Count(); i++)
                {
                    Console.WriteLine(counter + " " + this.Potions[i].name + " with resell value of " +this.Potions[i].ResellValue);
                    counter++;
                }
                Console.WriteLine("Please enter number");
                var conversionResult = int.TryParse(Console.ReadLine(), out int result);
                if (conversionResult)
                {
                    Console.WriteLine("You choose: " + Potions[result - 1].name);
                    this.Sell(result, input, hero);
                }
                else
                {
                    Console.WriteLine("Enter any key return to menu");
                    return;
                }
            }
            else
            {
                return;
            }
        }

        public void SellFromUser(int result, string input)
        {
            if (input == "1")
            {
                Console.WriteLine("Weapon is a " + Weapons[result - 1].Name + " of resell value " + Weapons[result - 1].ResellValue);
                //this.hero.Gold = this.hero.Gold + this.hero.WeaponsBag[result - 1].ResellValue;
                this.hero.WeaponsBag.Remove(Weapons[result - 1]);
                foreach (var item in hero.WeaponsBag)
                {
                    Console.WriteLine(item.Name);
                }
            }
            if (input == "2")
            {
                Console.WriteLine("Armor is a " + Armor[result - 1].Name + " of resell value " + Armor[result - 1].ResellValue);
                //this.hero.Gold = this.hero.Gold + this.hero.ArmorsBag[result - 1].ResellValue;
                this.hero.ArmorsBag.Remove(Armor[result - 1]);
                foreach (var item in hero.ArmorsBag)
                {
                    Console.WriteLine(item.Name);
                }
            }
            if (input == "3")
            {
                Console.WriteLine("Potion is a " + Potions[result - 1].name + " of resell value " + Potions[result - 1].ResellValue);
            }
        }
    }
}