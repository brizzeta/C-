using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._03.Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double table_price = 20.5;

            Component component1 = new Leaf("Room 1");
            Component component2 = new Leaf("Room 2");

            Console.Write("Enter count of tables for 1 room: ");
            int table_count = int.Parse(Console.ReadLine());
            double price1 = table_price * table_count;

            Console.Write("Enter count of tables for 2 room: ");
            table_count = int.Parse(Console.ReadLine());
            double price2 = table_price * table_count;

            component1.SetPrice(price1);
            component2.SetPrice(price2);

            Console.WriteLine("\n\nPRICE\n\n1 room: " + component1.GetPrice() + "\n2 room: " + component2.GetPrice());
        }
    }
}
