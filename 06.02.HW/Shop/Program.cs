using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class Program
    {
        class Shop
        {
            string name;
            string address;
            string desription;
            string num;
            string email;
            public Shop(string name, string address, string desription, string num, string email)
            {
                this.name = name;
                this.address = address;
                this.desription = desription;
                this.num = num;
                this.email = email;
            }
            public string Name
            {
                get => name;
                set => name = value;
            }
            public string Address
            {
                get => address;
                set => address = value;
            }
            public string Desription
            {
                get => desription; 
                set => desription = value;
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
                Console.WriteLine($"Name: {name}\nAddress: {address}\nDescription: {desription}\nPhone: {num}\nEmail: {email}");
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
