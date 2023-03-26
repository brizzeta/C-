using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03.Composite
{
    internal interface Component
    {
        void SetPrice(double price);
        double GetPrice();
    }
    internal class Composite : Component
    {
        private List<Component> _children = new List<Component>();
        private double price;
        public void Add(Component component)
        {
            _children.Add(component);
        }
        public void Remove(Component component)
        {
            _children.Remove(component);
        }
        public void SetPrice(double price)
        {
            this.price = price;
        }
        public double GetPrice()
        {
            foreach (Component component in _children)
            {
                price += component.GetPrice();
            }
            return price;
        }
    }
}
