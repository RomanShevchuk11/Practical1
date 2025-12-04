using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    public abstract class MenuItem : IMenuItem
    {
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }
        public string Category { get; protected set; }

        public MenuItem(string name, decimal price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public abstract string GetInfo();
    }
}
