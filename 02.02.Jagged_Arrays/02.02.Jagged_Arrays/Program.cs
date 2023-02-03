using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.Jagged_Arrays
{
    internal class Program
    {
        static void Task_1()
        {
            int size = 4;
            int[][] point = new int[size][];
            Random rnd = new Random();

            for(int i = 0; i < size; i++)                  //заполнение и вывод массива
            {
                point[i] = new int[size];
                for(int k = 0; k < size; k++)
                {
                    point[i][k] = rnd.Next(0, 10);
                    Console.Write(point[i][k] + "\t");
                }
                Console.WriteLine();
            }

            int[] sum = new int[size];
            for(int i = 0; i < size; i++)                   //считаем суммы строк
            {
                sum[i] = point[i].Sum();
            }

            int[] arr = point[Array.IndexOf(sum, sum.Min())];        //запомниаем строку с минимальной суммой
            point[Array.IndexOf(sum, sum.Min())] = point[Array.IndexOf(sum, sum.Max())];   //меняем местами строки
            point[Array.IndexOf(sum, sum.Max())] = arr;

            Console.WriteLine("\nResult:\n");

            for(int i = 0; i < size; i++)
            {
                foreach (int el in point[i])
                {
                    Console.Write(el + "\t");
                }
                Console.WriteLine();
            }            
        }
        static void Task_2()
        {
            int str = 4;
            int lenght = 6;
            int[][] point = new int[str][];
            Random rnd = new Random();

            for (int i = 0; i < str; i++, lenght--)                  //заполнение и вывод массива
            {
                point[i] = new int[lenght];
                for (int k = 0; k < lenght; k++)
                {
                    point[i][k] = rnd.Next(0, 10);
                    Console.Write(point[i][k] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Task_1();
            //Task_2();
        }
    }
}
