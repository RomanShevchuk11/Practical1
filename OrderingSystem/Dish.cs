using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    public class Dish : MenuItem
    {
        public string Type { get; set; }

        public Dish(string name, decimal price, string category, string type)
            : base(name, price, category)
        {
            Type = type;
        }

        public override string GetInfo()
        {
            return $"{Name} ({Type}) - {Price} грн";
        }
    }
}
