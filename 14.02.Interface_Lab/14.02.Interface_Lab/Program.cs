using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mass_name;

namespace _14._02.Interface_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mass arr = new Mass(5);
            arr.Show("It is an array.");
            Console.WriteLine("\nAverage: " + arr.Avg());
            arr.SortAsc();
            arr.Show();
        }
    }
}
