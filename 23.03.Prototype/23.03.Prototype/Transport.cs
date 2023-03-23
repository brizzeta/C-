using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._03.Prototype
{
    internal abstract class Transport : IClone
    {
        public string Name { get; set; }
        public double Fuel { get; set; }
        public double Price { get; set; }
        public Engine engine { get; set; }
        public abstract IClone Clone();
        public override string ToString()
        {
            return $"Name: {Name}\nFuel: {Fuel}\nPrice: {Price}";
        }
    }
    internal class Airplane : Transport
    {
        public string CabinCount { get; set; }
        public Airplane(string cabinCount)
        {
            Name = "Airplane";
            Fuel = 0;
            Price = 0;
            engine = new Engine();
            CabinCount = cabinCount;
        }
        public override IClone Clone()
        {
            Airplane obj = (Airplane)this.MemberwiseClone();
            obj.Name = Name;
            obj.Fuel = Fuel;
            obj.Price = Price;
            obj.engine = engine;
            obj.CabinCount = CabinCount;

            obj.engine = (Engine)engine.Clone();
            return obj;
        }
    }
    internal class Car : Transport
    {
        public string Color { get; set; }
        public Car(string color)
        {
            Name = "Car";
            Fuel = 0;
            Price = 0;
            engine = new Engine();
            Color = color;
        }
        public override IClone Clone()
        {
            Car obj = (Car)this.MemberwiseClone();
            obj.Name = Name;
            obj.Fuel = Fuel;
            obj.Price = Price;
            obj.engine = engine;
            obj.Color = Color;

            obj.engine = (Engine)engine.Clone();
            return obj;
        }
    }
    internal class Ship : Transport
    {
        public int FloorsCount { get; set; }
        public Ship(int floorsCount)
        {
            Name = "Ship";
            Fuel = 0;
            Price = 0;
            engine = new Engine();
            FloorsCount = floorsCount;
        }
        public override IClone Clone()
        {
            Ship obj = (Ship)this.MemberwiseClone();
            obj.Name = Name;
            obj.Fuel = Fuel;
            obj.Price = Price;
            obj.engine = engine;
            obj.FloorsCount = FloorsCount;

            obj.engine = (Engine)engine.Clone();
            return obj;
        }
    }
}
