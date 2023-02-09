using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_name;
using Matrix_name;
using City_name;
using Card_name;

namespace _08._02.Overloading_operations
{
    internal class Program
    {
        static void Task_Employee()
        {
            string n = "Motorina Nikol Pavlovna";
            Employee a = new Employee(n, "16.10.2003", "+399232399932", "nikol@gmail.com", "programmer", "coding", 30000);
            Console.WriteLine(a.ToString());

            a = a + 5;
            Console.WriteLine(a.ToString());

            a = a - 20000;
            Console.WriteLine(a.ToString());

            Employee b = new Employee(n, "16.10.2003", "+399232399932", "nikol@gmail.com", "programmer", "coding", 10005);
            Console.WriteLine(b != a);

            b.Salary = 10000;
            Console.WriteLine(b < a);
        }
        static void Task_Matrix()
        {
            Matrix m1 = new Matrix();
            Console.WriteLine("1 matrix:\n");
            m1.Print();

            Console.WriteLine();

            Matrix m2 = new Matrix();
            Console.WriteLine("2 matrix:\n");
            m2.Print();

            Console.WriteLine();

            m1 = m1 + m2;
            m1.Print();

            Console.WriteLine();

            Console.WriteLine("\n" + (m1 == m2));
        }
        static void Task_City()
        {
            string[] d = { "Odeska", "Zaporizka" };
            City c = new City("Odesa", "Ukraine", 1000000, "+38", d);
            c.Print();

            Console.WriteLine("\n" + (c + 5));
            c.Print();
        }
        static void Task_Card()
        {
            try
            {
                Card c = new Card("4444444444454444", "Nikol Motorina Pavlovna", "283", "17/24", 40000);
                Console.WriteLine(c.ToString() + "\n");

                c = c + 50;
                Console.WriteLine(c.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            //Task_Employee();
            //Task_Matrix();
            //Task_City();
            Task_Card();
        }
    }
}
