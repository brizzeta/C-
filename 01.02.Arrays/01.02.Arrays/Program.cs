using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._02.Arrays
{
    internal class Program
    {
        static void Task_0() 
        {
            int[] arr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 20);
            }
            foreach (int el in arr)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }
        static void Task_1()
        {
            int[] arr = new int[] { 1, 2, 5, 5, 2, 3, 10, 4, 8, 8, 1 };
            int even = 0, odd = 0;
            int uniq = arr.Distinct().Count() - (arr.Length - arr.Distinct().Count()); // кол-во уникальных элементов
            
            foreach (int el in arr)       
            {
                if (el % 2 == 0)      // четные/нечетные элементы
                {
                    even++;
                }
                else odd++;
            }
            Console.WriteLine($"Amount of even el: {even}");
            Console.WriteLine($"Amount of odd el: {odd}");
            Console.WriteLine($"Amount of uniq el: {uniq}");
        }
        static void Task_2()
        {
            int[] arr = new int[10];
            Random rand = new Random();

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100);
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            Console.Write("Enter number (1-100): ");
            int max = int.Parse(Console.ReadLine());

            Console.Write($"Elements < {max}: ");
            foreach(int el in arr)
            {
                if(el < max) Console.Write(el + " ");
            }
            Console.WriteLine();
        }
        static void Task_3()
        {
            Console.WriteLine("Enter 3 numbers (0-100): ");
            int[] nums = new int[3];

            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            int[] arr = new int[20];
            Random rand = new Random();

            Console.WriteLine();
            Console.Write("Array: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
                Console.Write(arr[i] + " ");
            }

            int count = 0;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i] == nums[0] && arr[i + 1] == nums[1] && arr[i + 2] == nums[2])
                {
                    count++;
                    i += 2;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Count of repeats: " + count);
        }
        static void Task_4()
        {
            int[] arr1 = new int[] { 10, 50, 7, 20, 4, 3, 4, 2, 5, 6};
            int[] arr2 = new int[] { 5, 7, 8, 10, 20, 34, 40, 3, 5, 6 };
            int[] uniq = (arr1.Except<int>(arr2)).ToArray();
            int[] common = new int[10];

            Console.Write("Common elements: ");
            int j = 0;

            foreach(int i in arr1)
            {
                for(int k = 0; k < uniq.Count(); k++)
                {
                    if (i != uniq[k])
                    {
                        common[j] = i;
                        j++;
                        break;
                    }
                }                
            }
            foreach (int i in common)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
        static void Task_5()
        {
            int[,] arr = new int[,] { { 5, 4, 3, 4, 20 }, { 5, 80, 10, 30, 2 } };
            int min = arr[0,0], max = arr[0,0];
            foreach(int i in arr)
            {
                if(min > i) min = i;
                if(max < i) max = i;
            }
            Console.WriteLine($"Maximum: {max}\nMinimun: {min}");
        }
        static void Task_6()
        {
            Console.Write("Enter sentence: ");
            string[] arr = Console.ReadLine().Split(' ');
            Console.WriteLine($"Amount of words: {arr.Count()}");
        }
        static void Task_7()
        {
            Console.Write("Enter sentence: ");
            string[] arr = Console.ReadLine().Split(' ');
            Console.Write("Result: ");

            for (int i = 0; i < arr.Count(); i++)
            {
                char[] charArray = arr[i].ToCharArray();
                Array.Reverse(charArray);
                Console.Write(new string(charArray) + " ");
            }
            Console.WriteLine();
        }
        static void Task_8()
        {
            char[] symb = new char[] { 'A', 'E', 'I', 'U', 'Y', 'O', 'a', 'e', 'i', 'u', 'y', 'o', };
            Console.Write("Enter sentence: ");
            string arr = Console.ReadLine();

            int vowel = 0;
            foreach(int i in symb)
            {
                foreach (int k in arr)
                {
                    if(i == k) vowel++;
                }
            }
            Console.WriteLine($"Count of vowel: {vowel}");
        }
        static void Task_9()
        {
            Console.Write("Enter sentence: ");
            string sent1 = Console.ReadLine();

            Console.Write("Enter sentence to search: ");
            string sent2 = Console.ReadLine();

            bool isIn = sent1.Contains(sent2);
            int count = 0;

            while(isIn == true)
            {
                count++;
                int ind = sent1.IndexOf(sent2);
                sent1 = sent1.Remove(ind, sent2.Length);
                isIn = sent1.Contains(sent2);
            }
            Console.WriteLine($"Count: {count}");
        }
        static void Main(string[] args)
        {
            Task_0();
            //Task_1();
            //Task_2();
            //Task_3();
            //Task_4();
            //Task_5();
            //Task_6();
            //Task_7();
            //Task_8();
            //Task_9();
        }
    }
}
