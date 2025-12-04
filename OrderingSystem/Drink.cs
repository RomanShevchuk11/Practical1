using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    public class Drink : MenuItem
    {
        public int Volume { get; set; }
        public bool IsAlcoholic { get; set; }

        public Drink(string name, decimal price, int volume, bool alcoholic)
            : base(name, price, alcoholic ? "Alcohol" : "Soft")
        {
            Volume = volume;
            IsAlcoholic = alcoholic;
        }

        public override string GetInfo()
        {
            return $"{Name} ({Volume} мл, {(IsAlcoholic ? "алкогольний" : "без алкоголю")}) - {Price} грн";
        }
    }
}
