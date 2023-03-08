using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._03.Linq
{
    class Device
    {
        public string Name { get; set; }
        public string Producer { get; set; }
        public double Price { get; set; }
        public Device(string name, string producer, double price)
        {
            Name = name;
            Producer = producer;
            Price = price;
        }
        public override string ToString() => $"Name: {Name}\nProducer: {Producer}\nPrice: {Price}";
    }
    internal class Program
    {        
        static void Main(string[] args)
        {
            List<Device> devices1 = new List<Device>()
            {
                new Device("Mobile phone", "Apple", 30000),
                new Device("Mobile phone", "Nokia", 3000),
                new Device("Laptop", "Apple", 30000)
            };
            List<Device> devices2 = new List<Device>()
            {
                new Device("Computer", "Acer", 40000),
                new Device("Mobile phone", "Samsung", 20000),
                new Device("Hairdryer", "Dyson", 15000)
            };

            var res = devices1.Except(devices2, new Sort());
            foreach(var device in res)
            {
                Console.WriteLine(device);
            }

            Console.WriteLine();

            var res2 = devices1.Intersect(devices2, new Sort());
            foreach (var device in res2)
            {
                Console.WriteLine(device);
            }

            Console.WriteLine();

            var res3 = devices1.Union(devices2, new Sort());
            foreach (var device in res3)
            {
                Console.WriteLine(device);
            }
        }
        public class Sort : IEqualityComparer<Device>
        {
            public bool Equals(Device a, Device b)
            {
                if (a.Name == b.Name)
                {
                    return true;
                }
                return false;
            }
            public int GetHashCode(Device obj)
            {
                return obj.Name.GetHashCode();
            }
        }
    }
}
