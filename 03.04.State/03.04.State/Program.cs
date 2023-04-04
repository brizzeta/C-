﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._04.State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Bank depositor");
            account.state = new SilverState(0.0, account);
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.PayInterest();
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);
            account.PayInterest();
        }
    }
}
