using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03.Composite
{
    internal class Leaf : Component
    {
        public string Name { get; set; }
        private double price;
        public Leaf(string name) { 
            Name = name;
        }
        public double GetPrice() => price;
        public void SetPrice(double price)
        {
            this.price = price;
        }
    }
}
