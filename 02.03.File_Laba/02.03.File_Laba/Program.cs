using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03.File_Laba
{
    internal class Program
    {
        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        static bool FibonacciNumber(int a)
        {
            int x, y, z, q = 0;
            y = z = x = 1;
            for (int i = 1; i < a; i++)
            {
                z = y;
                y = x;
                x = z + y;
                if (x == a)
                {
                    q = 1;
                }
            }
            if (q == 1)
            {
                return true;
            }
            return false;
        }
        static void Task1()
        {
            int[] arr = new int[100];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]) == true)
                {
                    list.Add(arr[i]);
                }
            }
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            List<int> list2 = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (FibonacciNumber(arr[i]) == true)
                {
                    list2.Add(arr[i]);
                }
            }
            foreach (int i in list2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            using (StreamWriter write = new StreamWriter("Arr.txt"))
            {
                foreach (int i in arr)
                {
                    write.Write(i + " ");
                }
            }
            using (StreamWriter write = new StreamWriter("Primes.txt"))
            {
                foreach (int i in list)
                {
                    write.Write(i + " ");
                }
            }
            using (StreamWriter write = new StreamWriter("Fibonacci.txt"))
            {
                foreach (int i in list2)
                {
                    write.Write(i + " ");
                }
            }
        }
        static void Task2()
        {
            string filecateg;
            string word, replace;
            Console.WriteLine("Enter file path");
            filecateg = Console.ReadLine();
            Console.WriteLine("Enter word");
            word = Console.ReadLine();
            Console.WriteLine("Enter replace word");
            replace = Console.ReadLine();
            using (StreamReader s = new StreamReader(filecateg, Encoding.UTF8))
            {
                string line;
                while ((line = s.ReadLine()) != null)
                {
                    string newLine = line.Replace(word, replace);
                    Console.Write(newLine);
                }
            }
        }
        static void Task3()
        {
            string filecateg, filecateg2;
            Console.WriteLine("Enter file to moderator word");
            filecateg = Console.ReadLine();
            Console.WriteLine("Enter file to text");
            filecateg2 = Console.ReadLine();
            List<string> wordmod = new List<string>();
            using (StreamReader reader = new StreamReader(filecateg))
            {
                string word;
                while ((word = reader.ReadLine()) != null)
                {
                    wordmod.Add(word);
                }
            }
            using (StreamReader reader = new StreamReader(filecateg2))
            {
                using (StreamWriter writer = new StreamWriter("Moder_text.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        foreach (string word in wordmod)
                        {
                            line = line.Replace(word, new string('*', word.Length));
                        }
                        writer.WriteLine(line);
                    }
                }
            }
        }
        static void Task4()
        {
            string filecateg;
            Console.WriteLine("Enter file to text");
            filecateg = Console.ReadLine();
            using (StreamReader reader = new StreamReader(filecateg, Encoding.UTF8))
            {
                using (StreamWriter writer = new StreamWriter("Result.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        line = new string(line.ToCharArray().Reverse().ToArray());
                        writer.WriteLine(line);
                    }
                }
            }
        }
        static void Task5()
        {
            using (StreamWriter writer = new StreamWriter("Numbers.txt"))
            {
                Random rand = new Random();
                for (int i = 1; i <= 100000; i++)
                {

                    writer.WriteLine(rand.Next(-100000, 100000));
                }
            }
            int negative = 0, positive = 0, twodigit = 0, fivedigit = 0;
            using (StreamReader reader = new StreamReader("Numbers.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int number = int.Parse(reader.ReadLine());
                    if (number > 0)
                    {
                        positive++;
                        using (StreamWriter writer = new StreamWriter("Positive.txt"))
                        {
                            writer.WriteLine(number);
                        }
                    }
                    if (number < 0)
                    {
                        negative++;
                        using (StreamWriter writer = new StreamWriter("Negative.txt"))
                        {
                            writer.WriteLine(number);
                        }
                    }
                    if (number > 10 && number < 100)
                    {
                        twodigit++;
                        using (StreamWriter writer = new StreamWriter("TwoDigit.txt"))
                        {
                            writer.WriteLine(number);
                        }
                    }
                    if (number > 10000 && number < 100000)
                    {
                        fivedigit++;
                        using (StreamWriter writer = new StreamWriter("FiveDigit.txt"))
                        {
                            writer.WriteLine(number);
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            Task5();
        }
    }
}
