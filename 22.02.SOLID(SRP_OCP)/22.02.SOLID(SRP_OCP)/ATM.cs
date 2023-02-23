using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._02.SOLID_SRP_OCP_
{
    public class ATM    //банкомат
    {        
        public int ATM_Cache { get; set; }
        ICurrency cur;
        ICheck check;
        public ATM() 
        { 
            ATM_Cache = 1000000;
        }
        public void SetCurrency()
        {
            Console.Write("Please, choose:\n1 UAH\n2 USD\n3 EUR\nAnswer: ");
            int answer = int.Parse(Console.ReadLine());

            switch(answer)
            {
                case 1:
                    cur = new Currency_UAH();                    
                    break;
                case 2:
                    cur = new Currency_USD();
                    break;
                case 3:
                    cur = new Currency_EUR();
                    break;
            }
            cur.SelectCurrency();
        }
        public void SetCheck()
        {
            Console.Write("Please, choose the check to:\n1 Email\n2 Print\n3 Not issue\nAnswer: ");
            int answer = int.Parse(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    check = new Email();
                    break;
                case 2:
                    check = new Print();
                    break;
                case 3:
                    check = new Not_Issue();
                    break;
            }
            check.SelectCheck();
        }
    }

    // работа с валютой
    public class Currency_UAH : ICurrency
    {
        public void SelectCurrency()
        {
            Console.WriteLine("Selected currencu: UAH");
        }
    }
    public class Currency_USD : ICurrency
    {
        public void SelectCurrency()
        {
            Console.WriteLine("Selected currencu: USD");
        }
    }
    public class Currency_EUR : ICurrency
    {
        public void SelectCurrency()
        {
            Console.WriteLine("Selected currencu: EUR");
        }
    }

    // работа с чеком
    public class Email : ICheck
    {
        public void SelectCheck()
        {
            Console.WriteLine("The check sent to your email.");
        }
    }
    public class Print : ICheck
    {
        public void SelectCheck()
        {
            Console.WriteLine("The check is printed.");
        }
    }
    public class Not_Issue : ICheck
    {
        public void SelectCheck()
        {
            Console.WriteLine("The check will not be issued.");
        }
    }
}
