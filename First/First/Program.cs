using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace First
{
    class Calc
    {
        int num1;
        int num2;
        public Calc(int first, int sec)
        {
            num1 = first; num2 = sec;
        }
        public int Plus()
        {
            return num1 + num2;
        }
        public int Minus()
        {
            return num1 - num2;
        }
        public int Mult()
        {
            return num1 * num2;
        }
        public int Divide()
        {
            return num1 / num2;
        }
    }

    class Calc_5
    {
        int num1;
        int num2;
        int num3;
        int num4;
        int num5;
        public Calc_5(int first, int sec, int third, int four, int fifth)
        {
            num1 = first; num2 = sec;
            num3 = third; num4 = four; 
            num5 = fifth;
        }
        public int Plus()
        {
            return num1 + num2 + num3 + num4 + num5;
        }
        public int Minus()
        {
            return num1 - num2 - num3 - num4 - num5;
        }
        public int Mult()
        {
            return num1 * num2 * num3 * num4 * num5;
        }
        public int Divide()
        {
            return num1 / num2 / num3 / num4 / num5;
        }
    }
    internal class Program
    {                                                    
        static void Main(string[] args)
        {
            //----ПРАКТИКА----//


            Console.WriteLine("Enter first number: ");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int sec = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter action sign: ");
            string sign = Console.ReadLine();

            Calc obj = new Calc(first, sec);

            int res = 0;

            switch (sign)
            {
                case "+":
                    res = obj.Plus();
                    break;
                case "-":
                    res = obj.Minus();
                    break;
                case "*":
                    res = obj.Mult();
                    break;
                case "/":
                    res = obj.Divide();
                    break;
            }
            Console.WriteLine($"Result: {res}");

            //----ЛАБОРАТОРКА----//
            //----1 ЗАДАНИЕ----//


            //Console.WriteLine("It's easy to win forgiveness for being wrong;\nbeing right is what gets you into real trouble.\nBjarne Stroustrup");


            //----2 ЗАДАНИЕ----//


            //Console.WriteLine("Enter numbers: ");
            //int first = int.Parse(Console.ReadLine());
            //int sec = int.Parse(Console.ReadLine());
            //int third = int.Parse(Console.ReadLine());
            //int four = int.Parse(Console.ReadLine());
            //int fifth = int.Parse(Console.ReadLine());

            //Calc_5 obj = new Calc_5(first, sec, third, four, fifth);

            //Console.WriteLine($"Plus: {obj.Plus()}");
            //Console.WriteLine($"Minus: {obj.Minus()}");
            //Console.WriteLine($"Multiply: {obj.Mult()}");
            //Console.WriteLine($"Divide: {obj.Divide()}");


            //----3 ЗАДАНИЕ----//


            //Console.WriteLine("Enter number: ");
            //int num = int.Parse(Console.ReadLine());
            //int res = 0;
            //int a = 0;
            //while (num != 0)
            //{
            //    a = num % 10;
            //    num /= 10;
            //    res = res * 10 + a;
            //}
            //Console.WriteLine($"Reverse: {res}");


            //----4 ЗАДАНИЕ----//


            //Console.WriteLine("Enter start number Fibonacci: ");
            //int start = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter last number Fibonacci: ");
            //int end = int.Parse(Console.ReadLine());

            //int first = 0, sec = 1, sum = 1;

            //for(int i = 1; i <= end; i++) 
            //{
            //    if (i >= start)
            //    {
            //        Console.Write(first + " ");
            //    }                
            //    first = sec;
            //    sec = sum;
            //    sum = first + sec;
            //}


            //----5 ЗАДАНИЕ----//


            //Console.WriteLine("Enter numbers A and B (A < B): ");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            //for (int i = 1; i <= b; i++) 
            //{ 
            //    if(i >= a)
            //    {
            //        for(int k = 1; k <= i; k++)
            //        {
            //            Console.Write(i);
            //        }
            //        Console.WriteLine();
            //    }                
            //}


            //----6 ЗАДАНИЕ----//


            //Console.WriteLine("Enter horizontal or vertical line (1/2): ");
            //int line = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter lenght of line: ");
            //int lenght = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter symbol of line: ");
            //string symb = Console.ReadLine();

            //Console.WriteLine();

            //for (int i = 1; i <= lenght; i++)
            //{
            //    Console.Write(symb);
            //    if(line == 2)
            //    {
            //        Console.WriteLine();
            //    }
            //}
        }
    }
}
