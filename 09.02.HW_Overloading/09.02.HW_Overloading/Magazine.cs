using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine_name
{
    class Magazine
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public string Num { get; set; }
        public string Email { get; set; }
        public int Count_employee { get; set; }
        public Magazine(string name, int year, string description, string num, string email, int count_employee)
        {
            Name = name;
            Year = year;
            Description = description;
            Num = num;
            Email = email;
            Count_employee = count_employee;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nYear: {Year}\nDescription: {Description}\nPhone: {Num}\nEmail: {Email}\nEmployee count: {Count_employee}";
        }
        public static Magazine operator+ (Magazine a, int b)
        {
            a.Count_employee += b;
            return a;
        }
        public static Magazine operator- (Magazine a, int b)
        {
            a.Count_employee -= b;
            return a;
        }
        public static bool operator ==(Magazine a, Magazine b)
        {
            return a.Count_employee == b.Count_employee;
        }
        public static bool operator !=(Magazine a, Magazine b)
        {
            return !(a == b);
        }
        public static bool operator <(Magazine a, Magazine b)
        {
            return a.Count_employee < b.Count_employee;
        }
        public static bool operator >(Magazine a, Magazine b)
        {
            return !(a < b);
        }
    }
}
