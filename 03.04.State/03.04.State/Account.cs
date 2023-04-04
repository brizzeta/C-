using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._04.State
{
    internal class Account
    {
        public State state { get; set; }
        string owner;
        public Account(string owner)
        {
            this.owner = owner;
        }
        public double GetBalance() => state.balance;
        public void Deposit(double amount)
        {
            state.Deposit(amount);
            Console.WriteLine($"Deposited {amount}$ -----");
            Console.WriteLine($"Balance {GetBalance()}$");
            Console.WriteLine($"Status {nameof(state)}");
        }
        public void Withdraw(double amount)
        {
            if (state.Withdraw(amount))
            {
                Console.WriteLine($"Withdraw {amount}$ -----");
                Console.WriteLine($"Balance {GetBalance()}$");
                Console.WriteLine($"Status {nameof(state)}");
            }
        }
        public void PayInterest()
        {
            if (state.PayInterest())
            {
                Console.WriteLine("Interest Paid -----");
                Console.WriteLine($"Balance {GetBalance()}");
                Console.WriteLine($"Status {nameof(state)}");
            }
        }
    }
}
