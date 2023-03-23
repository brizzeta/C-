using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._03.Prototype
{
    internal class Engine : IClone
    {
        public int Power { get; set; }
        public int CountCylinders { get; set; }
        public Engine(Engine engine) 
        { 
            Power = engine.Power;
            CountCylinders = engine.CountCylinders;
        }
        public Engine()
        {
            Power = 0;
            CountCylinders = 0;
        }
        public IClone Clone()
        {
            Engine temp = new Engine();
            temp.Power = Power;
            temp.CountCylinders = CountCylinders;
            return temp;
        }
    }
}
