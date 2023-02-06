using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web
{
    internal class Program
    {
        class Web
        {
            string name;
            string path;
            string description;
            string ip;
            public Web(string name, string path, string description, string ip)
            {
                this.name = name;
                this.path = path;
                this.description = description;
                this.ip = ip;
            }
            public string Name
            {
                get => name;
                set => name = value;
            }
            public string Path
            {
                get => path;
                set => path = value;
            }
            public string Description
            {
                get => description; 
                set => description = value;
            }
            public string Ip
            {
                get => ip; 
                set => ip = value;
            }
            public void ToString()
            {
                Console.WriteLine($"Name: {name}\nPath: {path}\nDescription: {description}\nIP: {ip}");
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
