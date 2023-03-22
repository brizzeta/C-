using System;

namespace _21._03.Abstract_Factory
{
    internal abstract class Herbivore
    {
        public abstract double Weight { get; set; }
        public abstract bool Life { get; set; }
        public abstract void Eat_grass();
    }
    internal class Wildebeeest : Herbivore
    {
        public override double Weight { get; set; }
        public override bool Life { get; set; }
        public override void Eat_grass()
        {
            Weight += 10;
            Console.WriteLine("Weight + 10");
        }
    }
    internal class Bison : Herbivore
    {
        public override double Weight { get; set; }
        public override bool Life { get; set; }
        public override void Eat_grass()
        {
            Weight += 10;
            Console.WriteLine("Weight + 10");
        }
    }
}
