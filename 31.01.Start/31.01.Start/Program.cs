using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._01.Start
{
    internal class Program
    {
        static void Task_1()
        {
            Console.WriteLine("Enter number 1-100: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 1 || num > 100)
            {
                Console.WriteLine("Error.");
            }
            else
            {
                if (num % 5 == 0 && num % 3 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
        }
        static void Task_2()
        {
            Console.WriteLine("Enter number and percent: ");
            int num = int.Parse(Console.ReadLine());
            int perc = int.Parse(Console.ReadLine());

            double res = (num * perc) / 100;
            Console.WriteLine("Result: " + res);
        }
        static void Task_3() {
            string res = "";
            for(int i = 0;i < 4; i++)
            {
                Console.WriteLine($"Enter {i + 1} number: ");
                res += Console.ReadLine();
            }
            Console.WriteLine($"Result: {res}");
        }
        static void Task_4()
        {
            Console.WriteLine("Enter number (6 signes): ");
            string num = Console.ReadLine();
            
            if (num.Length != 6)
            {
                Console.WriteLine("Not 6 signes.");
            }
            else
            {
                Console.WriteLine("Enter 2 numbers of digits to change: ");
                int dig1 = int.Parse(Console.ReadLine());
                int dig2 = int.Parse(Console.ReadLine());

                char num1 = num[dig1 - 1];
                num = num.Remove(dig1 - 1, 1).Insert(dig1 - 1, num[dig2 - 1].ToString());
                num = num.Remove(dig2 - 1, 1).Insert(dig2 - 1, num1.ToString());

                Console.WriteLine(num);
            }
        }
        static void Task_5()
        {
            Console.WriteLine("Enter date (dd.MM.yyyy):");
            string date = Console.ReadLine();

            DateTime dateTime = DateTime.Parse(date);

            string month;
            if(dateTime.Month == 12 || dateTime.Month == 1 || dateTime.Month == 2)
            {
                month = "Winter";
            }
            else if(dateTime.Month == 3 || dateTime.Month == 4 || dateTime.Month == 5)
            {
                month = "Spring";
            }
            else if (dateTime.Month == 6 || dateTime.Month == 7 || dateTime.Month == 8)
            {
                month = "Summer";
            }
            else
            {
                month = "Autumn";
            }
            Console.WriteLine(month + " " + dateTime.DayOfWeek);
        }
        static void Task_6()
        {
            Console.WriteLine("Temperature in Celsius or Fahrenheit (1/2): ");
            int var = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter temperature: ");
            double temp = double.Parse(Console.ReadLine());

            switch(var)
            {
                case 1:
                    temp = temp * 1.8 + 32;
                    break;
                case 2:
                    temp = (temp - 32) * 5 / 9;
                    break;
                default: 
                    Console.WriteLine("Error.");
                    break;
            }
            Console.WriteLine(temp);
        }
        static void Task_7()
        {
            Console.WriteLine("Enter 2 numbers (range): ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
                        
            while(num1 == num2)
            {
                Console.WriteLine("Enter 2 numbers (range) CORRECTLY: ");
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
            }
            if (num1 > num2)
            {
                int num = num1;
                num1 = num2;
                num2 = num;
            }

            for(int i = num1; i <= num2; i++)
            {
                if (i % 2 == 0) Console.Write(i + " ");
            }
            Console.WriteLine();
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
