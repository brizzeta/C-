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
        delegate void MyDelegate1(int number1, int number2, int number3);
        delegate void MyDelegate3();
        delegate void MyDelegate4(int[] arr);
        delegate int MyDelegate5(int[] arr, int count_number);
        delegate bool MyDelegate6(string str1, string word1);

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

            ////рюкзак
            //Backpack obj = new Backpack();
            //obj.Input();
            //Console.WriteLine(obj);
            //MyDelegate3 del = delegate ()
            //{
            //    obj.ev += obj.AddItem;
            //    obj.Event();
            //};
            //del();
            //Console.WriteLine(obj);

            ////3 задание
            //int[] arr2 = new int[10];
            //MyDelegate4 Init = (int[] arr) =>
            //{
            //    Random rand = new Random();
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        arr[i] = rand.Next(1, 20);
            //    }
            //};

            //MyDelegate4 Out = (int[] arr) =>
            //{
            //    foreach (int i in arr)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    Console.WriteLine();
            //};

            //Init(arr2);
            //Out(arr2);

            //MyDelegate5 countnumber = (int[] arr, int count_number) =>
            //{
            //    count_number = arr.Length;
            //    return count_number;
            //};

            //int count = 0;

            //Console.WriteLine(countnumber(arr2, count));


            ////4 задание
            //int[] arr2 = new int[10];
            //MyDelegate4 Init = (int[] arr) =>
            //{
            //    Random rand = new Random();
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        arr[i] = rand.Next(-20, 20);
            //    }
            //};

            //MyDelegate4 Out = (int[] arr) =>
            //{
            //    foreach (int i in arr)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    Console.WriteLine();
            //};

            //Init(arr2);
            //Out(arr2);

            //MyDelegate5 countnumber = (int[] arr, int count_number) =>
            //{
            //    foreach (int i in arr)
            //        if (i >= 0)
            //        {
            //            count_number++;
            //        }
            //    return count_number;
            //};

            //int count = 0;

            //Console.WriteLine(countnumber(arr2, count));


            ////5 задание
            //int[] arr2 = new int[10];
            //MyDelegate4 Init = (int[] arr) =>
            //{
            //    Random rand = new Random();
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        arr[i] = rand.Next(-20, 20);
            //    }
            //};

            //MyDelegate4 Out = (int[] arr) =>
            //{
            //    foreach (int i in arr)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    Console.WriteLine();
            //};

            //Init(arr2);
            //Out(arr2);

            //MyDelegate5 countnumber = (int[] arr, int count_number) =>
            //{
            //    foreach (int i in arr)
            //        if (i < 0)
            //        {
            //            count_number++;
            //        }
            //    return count_number;
            //};

            //int count = 0;

            //Console.WriteLine(countnumber(arr2, count));



            ////6 задание
            //string str;
            //string[] str2;
            //string word;
            //Console.WriteLine("Enter text");
            //str = Console.ReadLine();
            //str2 = str.Split(' ');
            //Console.WriteLine("Enter word for the search");
            //word = Console.ReadLine();
            //MyDelegate6 search = (string str1, string word1) => str2.Contains(word1);
            //Console.WriteLine(search(str, word));
        }
        static void Main(string[] args)
        {
            //Laboratory();
            HW();
        }
    }
}
