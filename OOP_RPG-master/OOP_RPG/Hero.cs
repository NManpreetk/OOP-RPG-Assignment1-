using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_RPG
{
    public class Hero
    {
       List<Potion> PotionBag { get; set; }

        public int Gold { get; set; }
        /*This is a Constructor.
        When we create a new object from our Hero class, the instance of this class, our hero, has:
        an empty List that has to contain instances of the Armor class,
        an empty List that has to contain instance of the Weapon class,
        stats of the "int" data type, including an intial strength and defense,
        original hitpoints that are going to be the same as the current hitpoints.
        */
        public Hero() {
            this.ArmorsBag = new List<Armor>();
            this.WeaponsBag = new List<Weapon>();
            this.PotionBag = new List<Potion>();
            this.Strength = 10;
            this.Defense = 10;
            this.OriginalHP = 30;
            this.CurrentHP = 30;
            this.Gold = 0;
            this.Speed = 7;
        }
        
        // These are the Properties of our Class.
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int OriginalHP { get; set; }
        public int CurrentHP { get; set; }
        public int Speed { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public Armor EquippedArmor { get; set; }
        

        public List<Armor> ArmorsBag { get; set;}
        public List<Weapon> WeaponsBag { get; set; }

        //These are the Methods of our Class.
        public void ShowStats() {
            Console.WriteLine("*****" + this.Name + "*****");
            Console.WriteLine("Strength: " + this.Strength);
            Console.WriteLine("Defense: " + this.Defense);
            Console.WriteLine("Hitpoints: " + this.CurrentHP + "/" + this.OriginalHP);
        }
        
        public void ShowInventory() {
            Console.WriteLine("*****  INVENTORY ******");
            Console.WriteLine("Weapons: ");
            foreach(var w in this.WeaponsBag){
                Console.WriteLine(w.Name + " of " + w.Strength + " Strength");
            }
            Console.WriteLine("Armor: ");
            foreach(var a in this.ArmorsBag){
                Console.WriteLine(a.Name + " of " + a.Defense + " Defense");
            }
        }
        
        public void EquipWeapon(int itemNumber) {
            if(WeaponsBag.Any()) {
                if(this.EquippedArmor == null)
                {
                    this.EquippedWeapon = this.WeaponsBag[itemNumber];
                    this.Strength = this.Strength + this.EquippedWeapon.Strength;
                    this.WeaponsBag.RemoveAt(itemNumber);
                }
                else
                {
                    this.Strength = this.Strength- this.EquippedWeapon.Strength;
                    this.WeaponsBag.Add(this.EquippedWeapon);
                    this.EquippedWeapon = this.WeaponsBag[itemNumber];
                    this.Strength = this.Strength + this.EquippedWeapon.Strength;
                    this.WeaponsBag.RemoveAt(itemNumber);
                }
            }
        }
        
        public void EquipArmor(int itemNumber) {
            if(ArmorsBag.Any()) {
                if (this.EquippedArmor == null)
                {
                    this.EquippedArmor = this.ArmorsBag[itemNumber];
                    this.Strength = this.Strength + this.EquippedArmor.Defense;
                    this.ArmorsBag.RemoveAt(itemNumber);
                }
                else
                {
                    this.Strength = this.Strength - this.EquippedArmor.Defense;
                    this.ArmorsBag.Add(this.EquippedArmor);
                    this.EquippedArmor = this.ArmorsBag[itemNumber];
                    this.Strength = this.Strength + this.EquippedArmor.Defense;
                    this.ArmorsBag.RemoveAt(itemNumber);
                }
            }
        }


        public void Equip()
        {
            Console.WriteLine("Please select an item which you want to equip");
            Console.WriteLine("1.Equip Weapons");
            Console.WriteLine("2.Equip Armor");
            Console.WriteLine("Please enter number");
            var conversionResult = int.TryParse(Console.ReadLine(), out int result);
            if (result == 1)
            {
                if (this.WeaponsBag.Count != 0)
                {
                    foreach (var item in this.WeaponsBag)
                    {
                        Console.WriteLine(this.WeaponsBag.Contains(item) + item.Name + " with" + item.Strength + " Strength ");
                    }
                    var selection = Console.ReadLine();
                    var s = Convert.ToInt32(selection);
                    if (selection == "0")
                    {
                        this.EquipWeapon(s);
                    }
                    if (selection == "1")
                    {
                        this.EquipWeapon(s);
                    }
                    if (selection == "2")
                    {
                        this.EquipWeapon(s);
                    }
                }
                else
                {
                    Console.WriteLine("there are no weapons!");
                }
            }

            else if (result == 2)
            {
                if (this.ArmorsBag.Count != 0)
                {
                    foreach (var item in this.ArmorsBag)
                    {
                        Console.WriteLine(this.ArmorsBag.Contains(item) + item.Name + " with" + item.Defense + " Strength ");
                    }
                    var selection = Console.ReadLine();
                    var s = Convert.ToInt32(selection);
                    if (selection == "0")
                    {
                        this.EquipArmor(s);
                    }
                    if (selection == "1")
                    {
                        this.EquipArmor(s);
                    }
                }
                else
                {
                    Console.WriteLine("there are no armors!");
                }
            }
        }

    }
}