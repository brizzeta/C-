using System;

namespace _21._03.Abstract_Factory
{
    internal abstract class Carnivore
    {
        public abstract double Power { get; set; }
        public abstract void Eat(Herbivore obj);
    }
    internal class Lion : Carnivore
    {
        public override double Power { get; set; }
        public override void Eat(Herbivore obj)
        {
            if (Power >= obj.Weight)
            {
                Power += 10;
                obj.Life = false;
                Console.WriteLine("Power + 10\nWildebeeest die");
            }
            else
            {
                Power -= 10;
                Console.WriteLine("Power - 10");
            }
        }
    }
    internal class Wolf : Carnivore
    {
        public override double Power { get; set; }
        public override void Eat(Herbivore obj)
        {
            if (Power >= obj.Weight)
            {
                Power += 10;
                obj.Life = false;
                Console.WriteLine("Power + 10\nWildebeeest die");
            }
            else
            {
                Power -= 10;
                Console.WriteLine("Power - 10");
            }
        }
    }
}
