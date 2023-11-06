using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Notebook._Binding
{
    internal class People
    {
        Human[] people;
        public People() { }
        public void GetFromFile()
        {

        }
    }
    internal class Human
    {
        public string Name { get; set; }
        public string Addres { get; set; }
        public string Phone { get; set; }
        public Human() 
        {
            Name = "Nastia";
        }
    }
}
