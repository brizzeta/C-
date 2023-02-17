using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _17._02.Laba_Delegate
{
    internal class Program
    {
        class Out
        {
            public string Str { get; set; }
            public void Print1(string str)
            {
                Console.WriteLine(str + "Print1");
            }
            public void Print2(string str)
            {
                Console.WriteLine(str + "Print2");
            }
        }
        class Math
        {
            public int A { get; set; }
            public int B { get; set; }
            public Math()
            {
                A = 0;
                B = 0;
            }
            public Math(int a, int b)
            {
                A = a;
                B = b;
            }
            public int Add() => A + B;
            public int Sub() => A - B;
            public int Mul() => A * B;
            public int Div() => A / B;
            public bool Parity_Check()
            {
                if(A % 2 == 0) return true;
                else return false;
            }
            public bool Odd_Check()
            {
                if(A % 2 != 0) return true;
                else return false;
            }
            public bool Prime_Check()
            {
                if(A > 1)
                {
                    for(int i = 2; i < A - 1; i++) 
                    { 
                        if(A % i == 0) return false;
                    }
                    return true;
                }
                else return false;
            }
            public bool Fibonacci_Check()
            {
                int a = 0;
                int b = 1;
                while(a <= A)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;
                    if (a == A) return true;
                }
                return false;
            }
        }
        delegate void GetAsStrin(string str);
        delegate int GetAsInt();
        delegate bool GetAsBool();
        static void Task_1()
        {
            Out str = new Out();
            str.Str = "String.";
            GetAsStrin d = str.Print1;
            d += str.Print2;
            d(str.Str);
        }
        static void Task_2_3()
        {
            Math math = new Math();
            GetAsInt[] d = { math.Add, math.Sub, math.Mul, math.Div };
            int choice = 0;

            while (choice != 5)
            {
                Console.Write("\n1 Add\n2 Sub \n3 Mult\n4 Div\n5 Exit\nYour choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice >= 1 && choice <= 4)
                {
                    Console.WriteLine("Enter 2 numbers: ");
                    math.A = int.Parse(Console.ReadLine());
                    math.B = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + d[choice - 1]());
                }
            }
            Console.WriteLine();

            GetAsBool[] d_bool = { math.Parity_Check, math.Odd_Check, math.Prime_Check, math.Fibonacci_Check };
            choice = 0;

            while (choice != 5)
            {
                Console.Write("\n1 Parity\n2 Odd\n3 Prime\n4 Fibonacci\n5 Exit\nYour choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice >= 1 && choice <= 4)
                {
                    Console.WriteLine("Enter 1 numbers: ");
                    math.A = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + d_bool[choice - 1]());
                }
            }

        }
        static void Main(string[] args)
        {
            //Task_1();
            Task_2_3();
        }
    }
}
