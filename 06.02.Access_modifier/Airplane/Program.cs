using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplane
{
    internal class Program
    {
        class Airplane
        {
            string company;
            string year;
            string type;
            public Airplane(string company, string year, string type)
            {
                this.company = company;
                this.year = year;
                this.type = type;
            }
            public void ToString()
            {
                Console.WriteLine($"Company: {company}\nYear: {year}\nType: {type}");
            }
            public string Company
            {
                get => company;
                set => company = value;
            }
            public string Year
            {
                get => year;
                set => year = value;
            }
            public string Type
            {
                get => type;
                set => type = value;
            }
        }
        static void Main(string[] args)
        {
            Airplane a = new Airplane("Hajy", "2012", "Jumbo");
            a.ToString();
        }
    }
}
