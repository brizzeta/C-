using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _17._02.Laba_Delegate
{
    //классы
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
        class Array
        {
            int[] arr;
            public Array()
            {
                arr = new int[0];
            }
            public Array(int size)
            {
                arr = new int[size];
            }
            public Array(int[] arr)
            {
                this.arr = arr;
            }
            public int this[int ind]
            {
                get
                {
                    if (ind >= 0 && ind < arr.Length) 
                        return arr[ind];
                    else throw new IndexOutOfRangeException();
                }
                set
                {
                    if (ind >= 0 && ind < arr.Length)
                        arr[ind] = value;
                    else throw new IndexOutOfRangeException();
                }
            }
            public void Even()
            {
                Console.WriteLine("Even elements:");
                for(int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0) Console.WriteLine(arr[i]);
                }
            }
            public void Odd()
            {
                Console.WriteLine("Odd elements:");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0) Console.WriteLine(arr[i]);
                }
            }
            public void Prime()
            {
                Console.WriteLine("Prime elements:");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > 1)
                    {
                        for (int k = 2; k < arr[i] - 1; i++)
                        {
                            if (arr[i] % k == 0) continue;
                        }
                        Console.WriteLine(arr[i]);
                    }
                }
            }
            public void Fibonacci()
            {
                Console.WriteLine("Fibonacci elements:");

                int a = 0;
                int b = 1;
                for (int i = 0; i < arr.Length; i++)
                {
                    while (a <= arr[i])
                    {
                        int temp = a;
                        a = b;
                        b = temp + b;
                        if (a == arr[i]) Console.WriteLine(arr[i]);
                    }
                }
            }
            public void Print()
            {
                Console.Write("Array: ");
                foreach(int i in arr) Console.WriteLine(i + " ");
            }
        }
        class Time
        {
            DateTime date;
            public void GetTime()
            {
                date = DateTime.Now;
                Console.Write("Time: ");
                Console.WriteLine(date.Hour + ":" + date.Minute + ":" + date.Second);
            }
            public void GetDate()
            {
                date = DateTime.Now;
                Console.Write("Date: ");
                Console.WriteLine(date.Year + "." + date.Month + "." + date.Day);
            }
            public void GetDayOfWeek()
            {
                date = DateTime.Now;
                Console.Write("Day of week: ");
                Console.WriteLine(date.DayOfWeek);
            }
        }

        //делегаты

        delegate void GetAsStrin(string str);
        delegate int GetAsInt();
        delegate bool GetAsBool();
        delegate void GetAsArr();
        delegate void GetAsDate();

        //выполнения заданий

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
        static void HW_1()
        {
            int[] array = { 1, 5, 3, 9, 4 };
            Array arr = new Array(array);

            GetAsArr[] d_arr = { arr.Even, arr.Odd, arr.Prime, arr.Fibonacci, arr.Print };
            int choice = 0;

            while (choice != 6)
            {
                Console.Write("\n1 Even\n2 Odd\n3 Prime\n4 Fibonacci\n5 Print\n6 Exit\nYour choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice >= 1 && choice <= 5)
                {
                    d_arr[choice - 1]();
                }
            }
        }
        static void HW_2()
        {
            Time t = new Time();
            GetAsDate[] d = { t.GetTime, t.GetDate, t.GetDayOfWeek };
            int choice = 0;

            while (choice != 4)
            {
                Console.Write("\n1 Get Time\n2 Get Date\n3 Get Day Of Week\n4 Exit\nYour choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice >= 1 && choice <= 3)
                {
                    d[choice - 1]();
                }
            }
        }
        static void Main(string[] args)
        {
            //Task_1();
            //Task_2_3();
            //HW_1();
            HW_2();
        }
    }
}
