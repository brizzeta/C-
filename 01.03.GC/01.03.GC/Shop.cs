using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03.GC
{
    interface IDisposable
    {
        void Dispose();
    }
    internal class Shop : IDisposable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public Shop(string name, string address, string type)
        {
            Name = name;
            Address = address;
            Type = type;
        }
        public override string ToString() => $"Name: {Name}\nAddress: {Address}\nType: {Type}";
        public void Dispose()
        {
            Name = null;
            Address = null;
            Type = null;
        }
        ~Shop() 
        { 
            Name = null;
            Address = null;
            Type = null;
        }
    }
}
