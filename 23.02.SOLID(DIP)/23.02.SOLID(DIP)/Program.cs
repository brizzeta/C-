using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _23._02.SOLID_DIP_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();

            Console.Write("Please, choose:\n1 EUR\n2 USD\n3 UAH\nAnswer: ");
            int answer = int.Parse(Console.ReadLine());

            ICurrency cur;

            switch (answer)
            {
                case 1:
                    cur = new Currency_EUR();
                    break;
                case 2:
                    cur = new Currency_USD();
                    break;
                default:
                    cur = new Currency_UAH();
                    break;
            }
            atm.SetCurrency(cur);

            ICheck check;

            Console.Write("Please, choose the check to:\n1 Email\n2 Print\n3 Not issue\nAnswer: ");
            answer = int.Parse(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    check = new Email();
                    break;
                case 2:
                    check = new Print();
                    break;
                default:
                    check = new Not_Issue();
                    break;
            }
            atm.SetCheck(check);
        }
    }
}
