using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _06._02.Access_modifier
{
    internal class Program
    {
        class City
        {
            string name;
            string country;
            int people_count;
            string tel_code;
            string[] districts;
            public void ToString()
            {
                Console.WriteLine($"City: {name}\nCountry: {country}\nCount of people: {people_count}\nTelephone code: {tel_code}\nDistricts:");
                foreach (string el in districts)
                {
                    Console.WriteLine(el);
                }
            }
            public City(string cty, string cntry, int p, string tel, string[] d)
            {
                name = cty;
                country = cntry;
                people_count = p;
                tel_code = tel;
                districts = d;
            }
            public string Name
            {
                get => name;
                set => name = value;
            }
            public string Country
            {
                get => country; 
                set => country = value;
            }
            public int People_count
            {
                get => people_count;
                set => people_count = value;
            }
            public string Tel_code
            {
                get => tel_code;
                set => tel_code = value;
            }
            public string this[int index]
            {
                get => districts[index];
                set => districts[index] = value;
            }
        }
        static void Main(string[] args)
        {
            string[] d = { "Odeska", "Zaporizka" };
            City c = new City("Odesa", "Ukraine", 1000000, "+38", d);
            c.ToString();
            Console.WriteLine("\nEnter distict 2: ");
            c[0] = Console.ReadLine();
            Console.WriteLine();
            c.ToString();
        }
    }
}
