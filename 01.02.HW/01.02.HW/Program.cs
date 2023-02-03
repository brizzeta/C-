using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._02.HW
{
    internal class Program
    {
        static void Task_1()
        {
            int[] A = new int[5];
            double[,] B = new double[3, 4];

            Console.WriteLine("Enter elements of array A:");
            for (int i = 0; i < A.Length; i++)                    //заполнение массива А
            {
                A[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();


            for (int i = 0; i < A.Length; i++)                   //вывод массива А
            {
                Console.Write(A[i] + " ");
            }

            Console.WriteLine("\n\n--------------------------------------------------\n");
            Random rand = new Random();

            for (int i = 0; i < B.GetLength(0); i++)              //заполнеие и вывод массива В
            {
                for (int k = 0; k < B.GetLength(1); k++)
                {
                    B[i, k] = rand.NextDouble() * 10;
                    Console.Write(B[i, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            List<double> common = new List<double>();                   //массив общих элементов

            foreach (int elA in A)
            {
                foreach (int elB in B)
                {
                    if (elA == elB)
                    {
                        common.Add(elA);
                    }
                }
            }

            Console.WriteLine($"Common max el: {common.Max()}");  //общее максимальное значение
            Console.WriteLine($"Common min el: {common.Min()}");  //общее минимальное значение

            double sum = A.Sum();                  //сумма всех элементов
            foreach (int el in B)
            {
                sum += el;
            }
            Console.WriteLine($"Sum: {sum}");

            double prod = 1;                      //произведение всех элементов
            foreach (int el in A)
            {
                prod *= el;
            }
            foreach (int el in B)
            {
                prod *= el;
            }
            Console.WriteLine($"Product: {prod}");

            int even = 0;                          //сумма четных элементов массива А
            foreach (int el in A)
            {
                if (el % 2 == 0) { even += el; };
            }
            Console.WriteLine($"Sum of even el in A: {even}");

            double odd = 0;                            //сумма нечетных столбцов В
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int t = 0; t < B.GetLength(1); t++)
                {
                    if (t % 2 == 0)
                    {
                        odd += B[i, t];
                    }
                }
            }
            Console.WriteLine($"Sum of odd columns of B: {odd}");
        }
        static void Task_2()
        {
            int[,] arr = new int[5, 5];
            Random random = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int k = 0; k < arr.GetLength(1); k++)
                {
                    arr[i, k] = random.Next(-100, 100);
                    Console.Write(arr[i, k] + " ");
                }
                Console.WriteLine();
            }

            int min = arr[0, 0];
            int max = arr[0, 0];
            int[] ind_min = new int[2];
            int[] ind_max = new int[2];

            for (int i = 0; i < arr.GetLength(0); i++)           //поиск мин и макс эл (первое вхождение)
            {
                for (int k = 0; k < arr.GetLength(1); k++)
                {
                    if (min > arr[i, k])
                    {
                        min = arr[i, k];
                        ind_min[0] = k;
                        ind_min[1] = (i + 1) * 10;
                    }
                    if (max < arr[i, k])
                    {
                        max = arr[i, k];
                        ind_max[0] = k;
                        ind_max[1] = (i + 1) * 10;
                    }
                }
            }

            Console.WriteLine("\nMin: " + min);
            Console.WriteLine("Max: " + max);

            int sum = 0;
            bool flag = false;
            int min_order = (ind_min[0]) + (ind_min[1]);    //номер под каким находится мин значение
            int max_order = (ind_max[0]) + (ind_max[1]);    //номер под каким находится макс значение

            if (min_order < max_order)
            {
                foreach (int el in arr)
                {
                    if (el == max)
                    {
                        break;
                    }
                    if (flag)
                    {
                        sum += el;
                        Console.WriteLine(el);
                    }
                    if (el == min)
                    {
                        flag = true;
                    }
                }
            }
            else
            {
                foreach (int el in arr)
                {
                    if (el == min)
                    {
                        break;
                    }
                    if (flag)
                    {
                        sum += el;
                    }
                    if (el == max)
                    {
                        flag = true;
                    }
                }
            }
            Console.WriteLine("\nSum: " + sum);
        }
        static void Task_3()
        {
            Console.Write("Enter a sentence: ");
            StringBuilder sent = new StringBuilder(Console.ReadLine());

            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < sent.Length; i++)                      //зашифровка
            {
                if (sent[i] == 'a')
                {
                    sent[i] = 'z';
                }
                else
                {
                    for (int k = 0; k < alphabet.Length; k++)
                    {
                        if (sent[i] == alphabet[k])
                        {
                            sent[i] = alphabet[k - 1];
                            break;
                        }
                    }
                }
            }
            Console.Write("\nEncrypt the sentence: " + sent);

            for (int i = 0; i < sent.Length; i++)                      //расшифровка
            {
                if (sent[i] == 'z')
                {
                    sent[i] = 'a';
                }
                else
                {
                    for (int k = 0; k < alphabet.Length; k++)
                    {
                        if (sent[i] == alphabet[k])
                        {
                            sent[i] = alphabet[k + 1];
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("\nDecrypt the sentence: " + sent);
        }
        static void Task_4()
        {
            int[,] matr = new int[5, 5];
            Random rand = new Random();
            Console.WriteLine("Matrix: \n");

            for (int i = 0; i < matr.GetLength(0); i++)            //заполнение матрицы и вывод
            {
                for (int k = 0; k < matr.GetLength(1); k++)
                {
                    matr[i, k] = rand.Next(0, 10);
                    Console.Write(matr[i, k] + "\t");
                }
                Console.WriteLine();
            }

            Console.Write("\nEnter number for multiply: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Result: \n");

            for (int i = 0; i < matr.GetLength(0); i++)                      //умножаем матрицу на число и выводим
            {
                for (int k = 0; k < matr.GetLength(1); k++)
                {
                    matr[i, k] *= num;
                    Console.Write(matr[i, k] + "\t");
                }
                Console.WriteLine();
            }

            int[,] matr2 = new int[5, 5];
            Console.WriteLine("\nMatrix 2: \n");

            for (int i = 0; i < matr2.GetLength(0); i++)            //заполнение матрицы 2 и вывод
            {
                for (int k = 0; k < matr2.GetLength(1); k++)
                {
                    matr2[i, k] = rand.Next(0, 10);
                    Console.Write(matr2[i, k] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatrix 1 * Matrix 2 = Matrix 1: \n");

            for (int i = 0; i < matr.GetLength(0); i++)            //перемножение матриц
            {
                for (int k = 0; k < matr.GetLength(1); k++)
                {
                    matr[i, k] *= matr2[i, k];
                    Console.Write(matr[i, k] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatrix 1 + Matrix 2 = Matrix 1: \n");

            for (int i = 0; i < matr.GetLength(0); i++)            //сложение матриц
            {
                for (int k = 0; k < matr.GetLength(1); k++)
                {
                    matr[i, k] += matr2[i, k];
                    Console.Write(matr[i, k] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Task_5()
        {
            Console.Write("Enter an equation: ");
            string[] eq = Console.ReadLine().Split(' ');
            int res = -1;

            switch (eq[1])
            {
                case "+":
                    res = Int32.Parse(eq[0]) + Int32.Parse(eq[2]);
                    break;
                case "-":
                    res = Int32.Parse(eq[0]) - Int32.Parse(eq[2]);
                    break;
                default:
                    Console.WriteLine("Something went wrong.");
                    break;
            }
            Console.WriteLine("Result: " + res);
        }
        static void Task_6()
        {
            Console.Write("Enter a text: ");
            StringBuilder sent = new StringBuilder(Console.ReadLine());

            string alpLow = "abcdefghijklmnopqrstuvwxyz";
            string alpUpp = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < sent.Length; i++)
            {
                if (i == 0)
                {
                    for (int k = 0; k < alpLow.Length; k++)
                    {
                        if (sent[i] == alpLow[k])
                        {
                            sent[i] = alpUpp[k];
                        }
                    }
                }
                else if (sent[i] == '.')
                {
                    for (int k = 0; k < alpLow.Length; k++)
                    {
                        if (sent[i + 2] == alpLow[k])
                        {
                            sent[i + 2] = alpUpp[k];
                        }
                    }
                }
            }
            Console.WriteLine("\nResult: " + sent);
        }
        static void Task_7()
        {
            Console.Write("Enter a text: ");
            string s = Console.ReadLine();

            string remove = "die";
            int count = (s.Length - s.Replace(remove, "").Length) / remove.Length;  //кол-во слов для замены

            s = s.Replace(remove, "***");   //заменяем

            Console.WriteLine($"\nResult: {s}\n\n{count} changed word {remove}\n");
        }
        static void Main(string[] args)
        {
            Task_1();
            //Task_2();
            //Task_3();
            //Task_4();
            //Task_5();
            //Task_6();
            //Task_7();
        }
    }
}
