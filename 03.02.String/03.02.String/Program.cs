using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03._02.String
{
    internal class Program
    {
        static void Task_1()                               //удаляем элемент из строки по индексу
        {
            Console.Write("Enter a sentense: ");
            StringBuilder s = new StringBuilder(Console.ReadLine());

            Console.Write("\nEnter index of element for remove: ");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("Result: " + s.Remove(i, 1));
        }
        static void Task_2()                             //удаляем все вхождения элемента в строку
        {
            Console.Write("Enter a sentense: ");
            StringBuilder s = new StringBuilder(Console.ReadLine());

            Console.Write("Enter a symbol to remove: ");
            string ch = Console.ReadLine();

            Console.WriteLine("Result: " + s.Replace(ch, ""));
        }
        static void Task_3()                             //добавляем элемент в строку по идексу 
        {
            Console.Write("Enter a sentense: ");
            string s = Console.ReadLine();

            Console.Write("Enter a symbol to add: ");
            string ch = Console.ReadLine();

            Console.Write("Enter an index: ");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine(s.Insert(i, ch));
        }
        static void Task_4()                                   //проверка на палиндром
        {
            Console.Write("Enter a string: ");
            string s = Console.ReadLine();
            string s2 = new string(s.ToCharArray().Reverse().ToArray());

            if(s.Equals(s2))
            {
                Console.WriteLine("Palindrom!");
            }
            else { Console.WriteLine("NOT a palindrom"); }
        }
        static void Task_5()                                   //посчитать кол-во слов в строке
        {
            Console.Write("Enter a sentense: ");
            int count = Console.ReadLine().Split(' ').Count();
            Console.WriteLine("Words: " + count);
        }
        static void Task_6()                                     //замена элементов в строке
        {
            Console.Write("Enter a sentense: ");
            StringBuilder s = new StringBuilder(Console.ReadLine());

            Console.Write("Enter an element to remove: ");
            string del = Console.ReadLine();

            Console.Write("Enter an element to add: ");
            string add = Console.ReadLine();

            Console.WriteLine("Result: " + s.Replace(del, add));
        }
        static void Task_7()                                   //смена мест соседних слов в строке
        {
            Console.Write("Enter a sentense: ");
            string[] s = Console.ReadLine().Split(' ');

            for(int i =0; i < s.Length - 1; i+=2)
            {
                string temp = s[i];
                s[i] = s[i + 1];
                s[i + 1] = temp;
            }

            Console.Write("Result: ");

            for (int i = 0; i < s.GetLength(0); i++)
            {
                Console.Write(s[i] + " ");
            }
            Console.WriteLine();
        }
        static void Task_8()                                    //кол-во "а" в конце слов
        {
            Console.Write("Enter a sentense: ");
            string[] s = Console.ReadLine().Split(' ');
            int count = 0;

            for(int i = 0; i < s.GetLength(0); i++)
            {
                char[] ch = s[i].ToCharArray();
                if (ch[ch.Length - 1] == 'а')
                {
                    count++;
                }
            }
            Console.WriteLine(@"'a': " + count);
        }
        static void Main(string[] args)
        {
            //Task_3();
            //Task_4();
            //Task_5();
            //Task_7();
            //Task_8();
            //----------------STRING---BUILDER------
            //Task_1();
            //Task_2();
            //Task_6();
        }
    }
}
