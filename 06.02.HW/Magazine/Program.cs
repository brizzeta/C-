using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine
{
    internal class Program
    {
        class Magazine
        {
            string name;
            int year;
            string description;
            string num;
            string email;        
            public Magazine(string name, int year, string description, string num, string email)
            {
                this.name = name;
                this.year = year;
                this.description = description;
                this.num = num;
                this.email = email;
            }
            public string Name
            {
                get => name;
                set => name = value;
            }
            public int Year
            {
                get => year;
                set => year = value;
            }
            public string Description
            {
                get => description;
                set => description = value;
            }
            public string Num
            {
                get => num;
                set => num = value;
            }
            public string Email
            {
                get => email;
                set => email = value;
            }
            public void ToString()
            {
                Console.WriteLine($"Name: {name}\nYear: {year}\nDescription: {description}\nPhone: {num}\nEmail: {email}");
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
