using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._03.Factory_method
{
    internal interface ITransport
    {
        void Deliver();
    }
    internal class RoadLogistic : ITransport
    {
        double Fuel { get; set; }
        double Price { get; set; }
        double Distance { get; set; }
        public RoadLogistic()
        {
            Fuel = 0;
            Price = 0; 
            Distance = 0;
        }
        public void Deliver()
        {
            Console.WriteLine("Delivered.");
        }
        public override string ToString()
        {
            return $"Road Logistics\n\nFuel - {Fuel}\nPrice - {Price}\nDistance - {Distance}";
        }
    }
    internal class SeaLogistic : ITransport
    {
        double Fuel { get; set; }
        double Price { get; set; }
        double Distance { get; set; }
        public SeaLogistic()
        {
            Fuel = 0;
            Price = 0;
            Distance = 0;
        }
        public void Deliver()
        {
            Console.WriteLine("Delivered.");
        }
        public override string ToString()
        {
            return $"Sea Logistics\n\nFuel - {Fuel}\nPrice - {Price}\nDistance - {Distance}";
        }
    }
    internal class AirLogistic : ITransport
    {
        double Fuel { get; set; }
        double Price { get; set; }
        double Distance { get; set; }
        public AirLogistic()
        {
            Fuel = 0;
            Price = 0;
            Distance = 0;
        }
        public void Deliver()
        {
            Console.WriteLine("Delivered.");
        }
        public override string ToString()
        {
            return $"Air Logistics\n\nFuel - {Fuel}\nPrice - {Price}\nDistance - {Distance}";
        }
    }
}
