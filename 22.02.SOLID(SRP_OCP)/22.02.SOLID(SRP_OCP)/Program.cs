using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._02.SOLID_SRP_OCP_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            atm.SetCurrency();
            atm.SetCheck();
        }
    }
}
