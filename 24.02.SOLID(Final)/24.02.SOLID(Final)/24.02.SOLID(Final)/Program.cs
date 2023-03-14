using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_02_SOLID_Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHuman[] obj3 = new Teacher[3];
            obj3[0] = new Teacher("Jack Vilson", "M", "34723897", "Odesa");
            obj3[1] = new Parents("Michael Vilson", "M", "35346234", "Kyiv");
            obj3[2] = new Student("Mike Huston", "M", "4362541234", "Lviv");
            IFaculty obj4 = new Programmer();
            University obj2 = new University();
            obj2.Faculties.Add(obj4);
            Roster obj = new Roster(obj2);
            ISort obj5 = new SortByNS(obj3[2], obj3[2]);

        }
    }
}
