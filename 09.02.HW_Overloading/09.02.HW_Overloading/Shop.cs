using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_name
{
    class Shop
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Desription { get; set; }
        public string Num { get; set; }
        public string Email { get; set; }
        public double Area { get; set; }
        public Shop(string name, string address, string desription, string num, string email, double area)
        {
            Name = name;
            Address = address;
            Desription = desription;
            Num = num;
            Email = email;
            Area = area;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nAddress: {Address}\nDescription: {Desription}\nPhone: {Num}\nEmail: {Email}\nArea: {Area}\n";
        }
        public static Shop operator +(Shop a, double b)
        {
            a.Area += b;
            return a;
        }
        public static Shop operator -(Shop a, double b)
        {
            a.Area -= b;
            return a;
        }
        public static bool operator ==(Shop a, Shop b)
        {
            return a.Area == b.Area;
        }
        public static bool operator !=(Shop a, Shop b)
        {
            return !(a == b);
        }
        public static bool operator <(Shop a, Shop b)
        {
            return a.Area < b.Area;
        }
        public static bool operator >(Shop a, Shop b)
        {
            return !(a > b);
        }
    }
}
