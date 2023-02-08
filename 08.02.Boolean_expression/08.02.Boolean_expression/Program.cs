using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._02.Boolean_expression
{
    internal class Program
    {
        class Expression
        {
            string expr;
            public Expression(string expr)
            {
                this.expr = expr;
            }
            public bool Check()
            {
                List<char> num1 = new List<char>();           //для записи 1 числа

                foreach(var item in expr) 
                {
                    if (item >= '0' && item <= '9')
                    {
                        num1.Add(item);
                    }
                    else break;
                }

                if (num1.Count == 0)               //если не введено сначала число
                    throw new Exception("First number is NOT entered.");

                List<char> oper = new List<char>();           //для записи оператора

                for(int item = num1.Count; item <= num1.Count + 2; item++)
                {
                    if (expr[item] == '!' || (expr[item] >= '<' && expr[item] <= '>'))
                    {
                        oper.Add(expr[item]);
                    }
                    else break;
                }

                if (oper.Count == 0)               //если не введен оператор
                    throw new Exception("Incorrect operator.");

                List<char> num2 = new List<char>();           //для записи 2 числа
                int count = num1.Count + oper.Count;

                for (int item = count; item < expr.Length; item++)
                {
                    if (expr[item] >= '0' && expr[item] <= '9')
                    {
                        num2.Add(expr[item]);
                    }
                    else throw new Exception("Incorrect second number.");
                }

                if (num2.Count == 0)               //если не введено 2 число
                    throw new Exception("Second number is NOT entered.");

                var res1 = new string(num1.ToArray());
                int number1 = int.Parse(res1);
                var res2 = new string(num2.ToArray());
                int number2 = int.Parse(res2);
                var operat = new string(oper.ToArray());

                if (number1 == number2 && operat == "==")
                {
                    return true;
                }
                else if(number1 >= number2 && operat == ">=")
                {
                    return true;
                }
                else if (number1 <= number2 && operat == "<=")
                {
                    return true;
                }
                else if (number1 != number2 && operat == "!=")
                {
                    return true;
                }
                else if (number1 > number2 && operat == ">")
                {
                    return true;
                }
                else if (number1 < number2 && operat == "<")
                {
                    return true;
                }
                else return false;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter boolean expression: ");
            string expr = Console.ReadLine();
            Expression e = new Expression(expr);
            try
            {
                if (e.Check() == true)
                {
                    Console.WriteLine("Equals.");
                }
                else Console.WriteLine("NOT equals.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
