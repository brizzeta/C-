using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._03.Prototype
{
    internal interface IClone
    {
        IClone Clone();
    }
    internal class Program
    {        
        static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.Power = 200;
            engine.CountCylinders = 5;

            Transport transport1 = new Car("Red");
            transport1.Fuel = 6;
            transport1.Price = 150000;
            transport1.engine = engine;

            Console.WriteLine(transport1.ToString() + "\n");

            Transport transport2 = (Transport)transport1.Clone();

            Console.WriteLine(transport2.ToString());
        }
    }
}
