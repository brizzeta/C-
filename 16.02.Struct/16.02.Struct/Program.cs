using Struct_name;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._02.Struct
{
    internal class Program
    {
        static void Task_1()
        {
            Fraction f1 = new Fraction(8, 4);
            Fraction f2 = new Fraction(4, 2);

            Console.WriteLine("f1 + f2 = " + f1.Add(f2));
        }
        static void Task_2()
        {
            Complex_num c1 = new Complex_num(2, 4);
            Complex_num c2 = new Complex_num(4, 8);

            Console.WriteLine("c1 - c2 = " + c1.Min(c2));
        }
        static void Task_3()
        {
            Birth hb = new Birth(2003, 10, 16);
            Console.WriteLine("Birthday week day: " + hb.Day_Week_Birth());
        }

        //--------------         ДЗ          -----------------

        static void Task_4()
        {
            Vector vec1 = new Vector();
            Console.WriteLine("Enter 1 vector.");
            vec1.Input();

            Vector vec2 = new Vector();
            Console.WriteLine("\nEnter 2 vector.");
            vec2.Input();

            Console.WriteLine($"\nLength of 1 vector: {vec1.GetLength()}");

            Vector vec3 = new Vector();
            vec3 = vec1.AddVector(vec2);
            Console.WriteLine($"\nSum of 1 and 2 vector:\n");
            vec3.ToString();

            if (vec1.Equals(vec2))
                Console.WriteLine("\nVectors ARE equals.");
            else
                Console.WriteLine("\nVectors are NOT equals.");
        }
        static void Task_5()
        {
            Decimal_number dec = new Decimal_number(2);
            Console.WriteLine("dec in Bin: " + dec.ToBin());
        }
        static void Task_6()
        {
            RGB_Color rgb = new RGB_Color(3, 5, 8);
            Console.WriteLine(rgb.ToHEX());

            CMYK cmyk = rgb.ToCMYK();
            Console.WriteLine(cmyk.ToString());
        }
        static void Main(string[] args)
        {
            //Task_1();
            //Task_2();
            //Task_3();
            //Task_4();
            //Task_5();
            Task_6();
        }
    }
}
