using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    public class Potion: Item
    {
        public int HP { get; set; }
        public string name { get; set; }
        public int OriginalValue { get; set; }
        public int ResellValue { get; set; }

        public Potion(int HP, string name, int OriginalValue, int ResellValue)
        {
            this.HP = HP;
            this.name = name;
            this.OriginalValue = OriginalValue;
            this.ResellValue = ResellValue;
        }
    }
}
