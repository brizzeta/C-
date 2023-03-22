using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._03.Abstract_Factory
{
    internal class Program
    {
        internal class Animal_World
        {
            private Herbivore herbivore;
            private Carnivore carnivore;
            public Animal_World(IContinent cont, int weight, int power)
            {
                herbivore = cont.Herbivore_Create();
                carnivore = cont.Carnivore_Create();

                herbivore.Weight = weight;
                carnivore.Power = power;
            }
            public void Eat_Herbivore()
            {
                herbivore.Eat_grass();
            }
            public void Eat_Carnivore()
            {
                carnivore.Eat(herbivore);
            }
        }
        static void Main(string[] args)
        {
            Animal_World world = new Animal_World(new Africa(), 50, 30);
            world.Eat_Herbivore();
            world.Eat_Carnivore();
        }
    }
}
