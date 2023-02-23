using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._02.SOLID_DIP_
{
    public class ATM    //банкомат
    {        
        public int ATM_Cache { get; set; }               
        public ATM() 
        { 
            ATM_Cache = 1000000;
        }
        public void SetCurrency(ICurrency cur)
        {           
            cur.SelectCurrency();
        }
        public void SetCheck(ICheck check)
        {            
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
