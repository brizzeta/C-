using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._02.Anonym_method
{
    internal class Program
    {
        delegate bool Del1(int x);
        delegate int Del2(int x);
        delegate int Del3(int[] x);
        delegate int[] Del4(int[] x);

        public class Backpack
        {
            public string Color { get; set; }
            public string Firm { get; set; }
            public string Textile { get; set; }
            public double Weight { get; set; }
            public double Volume { get; set; }
            
        }
        static void Laboratory()
        {
            //четность числа
            Console.Write("Enter number: ");
            int answ = int.Parse(Console.ReadLine());
                        
            Del1 myDel1 = delegate (int x)  
            {
                return x % 2 == 0;
            };

            if (myDel1(answ)) Console.WriteLine("Even.");
            else Console.WriteLine("Odd.");

            //квадрат числа
            Console.Write("Enter number: ");
            answ = int.Parse(Console.ReadLine());
                        
            Del2 myDel2 = delegate (int x)
            {
                return x * x;
            };

            Console.WriteLine("Square: " + myDel2(answ));

            //куб числа
            Console.Write("Enter number: ");
            answ = int.Parse(Console.ReadLine());
                        
            Del2 myDel3 = x => x * x * x;

            Console.WriteLine("Square: " + myDel3(answ));

            //день программиста числа
            Console.Write("Enter the number of the day: ");
            answ = int.Parse(Console.ReadLine());
                        
            Del1 myDel4 = x => x == 256 ? true : false;

            if (myDel4(answ)) Console.WriteLine("It's Programmer Day.");
            else Console.WriteLine("It is NOT Programmer Day.");

            //максимум в массиве
            Console.Write("Enter numbers: ");
            string[] array = Console.ReadLine().Split(' ');
            int[] arr = new int[array.Length];

            for(int i = 0; i < arr.Length; i++) arr[i] = int.Parse(array[i]);

            Del3 myDel5 = x => x.Max();

            Console.WriteLine("Max number: " + myDel5(arr));

            //минимум в массиве
            Console.Write("Enter numbers: ");
            string[] array2 = Console.ReadLine().Split(' ');
            int[] arr2 = new int[array2.Length];

            for (int i = 0; i < arr2.Length; i++) arr2[i] = int.Parse(array2[i]);

            Del3 myDel6 = x => x.Min();

            Console.WriteLine("Min number: " + myDel6(arr2));

            //четные эл в массиве
            Console.Write("Enter numbers: ");
            string[] array3 = Console.ReadLine().Split(' ');
            int[] arr3 = new int[array2.Length];

            for (int i = 0; i < arr3.Length; i++) arr3[i] = int.Parse(array3[i]);

            Del2 myDel7 = x => x % 2 != 0 ? 1 : 0;

            Console.Write("Odd numbers: ");

            foreach(int el in arr3)
            {
                Console.Write(myDel7(el) + " ");
            }

            Console.WriteLine();
        }

        static void HW()
        {
            //RGB
            Console.Write("RGB: ");
            string[] str1 = Console.ReadLine().Split(' ');
            int[] arr1 = new int[str1.Length];

            for (int i = 0; i < arr1.Length; i++) arr1[i] = int.Parse(str1[i]);

            Del2 myDel7 = x => x % 2 != 0 ? 1 : 0;

            Console.Write("RGB: ");

            foreach (int el in arr1)
            {
                Console.Write(myDel7(el) + " ");
            }

            //
        }
        static void Main(string[] args)
        {
            Laboratory();

        }
    }
}
