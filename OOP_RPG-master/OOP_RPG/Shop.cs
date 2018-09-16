using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    class Shop
    {
        private Game game;

        public List<Armor> Armor { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<Potion> Potions { get; set; }
        public string name { get; set; }
        public string OriginalValue { get; set; }
        public int itemNumber { get; set; }
        public int i { get; set; }
        public Hero hero { get; set; }
        public Item item { get; set; }

        public Shop()
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
        }

        public Shop(Hero hero, Game game)
        {
            this.hero = hero;
            this.game = game;
        }

        public void Menu(Hero hero, Game game)
        {
            Console.WriteLine("Welcome to my shop! What would you like to do?");
            Console.WriteLine("a) Buy Item");
            Console.WriteLine("b) Sell Item");
            Console.WriteLine("c) Return to Game Menu");
            var input = Console.ReadLine();
            if (input == "a")
            {
                //Console.WriteLine("1. Weapons");
                //Console.WriteLine("2. Armor");
                //Console.WriteLine("3. potion");
                //this.ShowInventory();
                this.weapons();
            }
            else if(input == "b")
            {
                this.BuyfromUser();
            }
            else
            {
                return;
            }
        }

        public void weapons()
        {
            Console.WriteLine("1. Weapons");
            Console.WriteLine("2. Armor");
            Console.WriteLine("3. potion");
            Console.ReadLine();
        }
        public void ShowInventory()
        {
            var counter = 1;
            Console.WriteLine("*****SHOP FOR WEAPONS*****");
            for (i = 0; i< this.Weapons.Count(); i++){
                Console.WriteLine(counter + " " +this.Weapons[i].Name + " with original value of " + + this.Weapons[i].OriginalValue);
                counter++;
            }
            
            Console.WriteLine("*****SHOP FOR ARMORS*****");
            for (i = 0; i < this.Armor.Count(); i++){
                Console.WriteLine(counter + " " + this.Armor[i].Name + " with original value of " + +this.Armor[i].OriginalValue);
                counter++;
            }
            
            Console.WriteLine("*****SHOP FOR POTIONS*****");
            for (i = 0; i < this.Potions.Count(); i++){
                Console.WriteLine(counter + " " + this.Potions[i].name + " with original value of " + +this.Potions[i].OriginalValue);
                counter++;
            }

            Console.WriteLine("Please enter number");
            Console.WriteLine("Please enter 'R' or any key to return to menu");
            var conversionResult = int.TryParse(Console.ReadLine(), out int result);
            if (conversionResult)
            {
                Console.WriteLine("You choose" + counter);
                this.SellFromUser(itemNumber);
            }
            else{
                Console.WriteLine("Enter any key return to menu");
                return;
            }

        }

        public void Sell(Item item)
        {
            if (hero.Gold >= item.OriginalValue)
            {
                Console.WriteLine(hero.Gold = hero.Gold - Weapons[i].OriginalValue);
            }
            else
            {
                Console.WriteLine("You do not have enough money to buy weapon");
            }
            Console.WriteLine("hello world");
            Console.ReadLine();
        }

        public void BuyfromUser()
        {
            var counter = 1;
            Console.WriteLine("*****RESELL WEAPONS*****");
            for (i = 0; i < this.Weapons.Count(); i++){
                Console.WriteLine(counter + " " + this.Weapons[i].Name + " with resell value of " +this.Weapons[i].ResellValue);
                counter++;
            }

            Console.WriteLine("*****RESELL ARMORS*****");
            for (i = 0; i < this.Armor.Count(); i++){
                Console.WriteLine(counter + " " + this.Armor[i].Name + " with resell value of " +this.Armor[i].ResellValue);
                counter++;
            }

            Console.WriteLine("*****RESELL POTIONS*****");
            for (i = 0; i < this.Potions.Count(); i++){
                Console.WriteLine(counter + " " + this.Potions[i].name + " with resell value of " +this.Potions[i].ResellValue);
                counter++;
            }

            Console.WriteLine("Please enter number");
            Console.WriteLine("Please enter 'R' or any key to return to menu");
            var input = int.TryParse(Console.ReadLine(), out int result);
            if (result == i){
                this.SellFromUser(itemNumber);
            }
            else{
                Console.WriteLine("Enter any key return to menu");
                return;
            }
        }

        public void SellFromUser(int itemNumber)
        {
            Console.WriteLine("hello world");
        }
    }
}
