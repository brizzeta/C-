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
            Console.WriteLine("Less than 5: " + arr.Less(5));
            Console.WriteLine();
            arr.ShowEven();
            Console.WriteLine("Count of unique elements: " + arr.CountDistinct());
        }
    }
}
