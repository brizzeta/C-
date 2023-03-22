using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._03.Abstract_Factory
{
    internal interface IContinent
    {
        Carnivore Carnivore_Create();
        Herbivore Herbivore_Create();
    }
    internal class Africa : IContinent
    {
        public Carnivore Carnivore_Create()
        {
            return new Lion();
        }
        public Herbivore Herbivore_Create()
        {
            return new Wildebeeest();
        }
    }
    internal class North_America : IContinent
    {
        public Carnivore Carnivore_Create()
        {
            return new Wolf();
        }
        public Herbivore Herbivore_Create()
        {
            return new Bison();
        }
    }
}
