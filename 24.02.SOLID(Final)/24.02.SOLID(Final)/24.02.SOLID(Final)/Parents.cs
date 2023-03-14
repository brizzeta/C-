using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_02_SOLID_Final
{
    internal class Parents : IHuman
    {
        string NS;
        string sex;
        string PassportData;
        string PlaceLive;

        public Parents()
        {
            NS = string.Empty;
            sex = string.Empty;
            PassportData = string.Empty;
            PlaceLive = string.Empty;
        }

        public Parents(string NS, string sex, string passportData, string placeLive)
        {
            this.NS = NS;
            this.sex = sex;
            PassportData = passportData;
            PlaceLive = placeLive;
        }

        public void Print()
        {
            Console.WriteLine("Enter Name Surname");
            NS = Console.ReadLine();
            Console.WriteLine("Enter your sex");
            sex = Console.ReadLine();
            Console.WriteLine("Enter passport data");
            PassportData = Console.ReadLine();
            Console.WriteLine("Enter your place live");
            PlaceLive = Console.ReadLine();
        }

        public string ns
        {
            get
            {
                return NS;
            }
            set
            {
                NS = value;
            }
        }

        public string Sex
        {
            get { return sex; } 
            set { sex = value; }
        }

        public string Passportdata
        {
            get
            {
                return PassportData;
            }
            set
            {
                PassportData = value;
            }
        }

        public string Placelive
        {
            get
            {
                return PlaceLive;
            }
            set
            {
                PlaceLive = value;
            }
        }
    }
}
