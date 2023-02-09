using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace City_name
{
    class City
    {
        string name;
        string country;
        int people_count;
        string tel_code;
        string[] districts;
        public void Print()
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
        public static City operator+ (City a, int b)        //работа с количеством жителей
        {
            a.people_count += b;
            return a;
        }
        public static City operator -(City a, int b)
        {
            a.people_count += b;
            return a;
        }
        public static bool operator ==(City a, City b)
        {
            return a.people_count == b.people_count;
        }
        public static bool operator !=(City a, City b)
        {
            return !(a == b);
        }
        public static bool operator <(City a, City b)
        {
            return a.people_count < b.people_count;
        }
        public static bool operator >(City a, City b)
        {
            return !(a < b);
        }
    }
}
