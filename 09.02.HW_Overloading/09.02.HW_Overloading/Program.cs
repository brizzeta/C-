using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazine_name;
using Shop_name;

namespace _09._02.HW_Overloading
{
    internal class Program
    {
        static void Task_Magazine()
        {
            Magazine m = new Magazine("Aurora", 2007, "Fashion", "+383902220990", "f@gmail.com", 10);
            Console.WriteLine(m.ToString() + "\n");

            m = m + 10;
            Console.WriteLine(m.ToString());
        }
        static void Task_Shop()
        {
            Shop s = new Shop("Aurora", "Lvivska", "Fashion", "+380002223344", "f@gmail.com", 60);
            Console.WriteLine(s.ToString());

            s = s + 60;
            Console.WriteLine(s.ToString());
        }
        static void Main(string[] args)
        {
            //Task_Magazine();
            Task_Shop();
        }
    }
}
