using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Program
    {
        class Employee
        {
            string[] name;
            string dob;
            string num;
            string email;
            string post;
            string respons;
            public Employee(string[] name, string d, string num, string e, string p, string r) 
            { 
                this.name = name;
                dob = d;
                this.num = num;
                email = e;
                post = p;
                respons = r;
            }
            public void ToString()
            {
                Console.Write("Name: ");
                foreach (string el in name)
                {
                    Console.Write(el + " ");
                }
                Console.WriteLine($"\nDOB: {dob}\nNumber: {num}\nEmail: {email}\nPost: {post}\nResponsibilities: {respons}");               
            }
            public string this[int index]
            {
                get => name[index];
                set => name[index] = value;
            }
            public string Dob
            {
                get => dob;
                set => dob = value;
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
            public string Post
            {
                get => post;
                set => post = value;
            }
            public string Respons
            {
                get => respons; 
                set => respons = value;
            }
        }
        static void Main(string[] args)
        {
            string[] n = { "Motorina", "Nikol", "Pavlovna" };
            Employee a = new Employee(n, "16.10.2003", "+399232399932", "nikol@gmail.com", "programmer", "coding");
            a.ToString();
        }
    }
}
