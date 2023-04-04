﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _03._04.State
{
    internal class SilverState : State
    {
        void Initialize()
        {
            interest = 0.01;
            lowerLimit = 0.0;
            upperLimit = 1000.0;
        }
        void StateChangeCheck()
        {
            if (balance < lowerLimit)
            {
                account.state = new RedState(this);
            }
            else if (balance > upperLimit)
            {
                account.state = new GoldState(this);
            }
        }
        public SilverState(double balance, Account account)
        {
            this.balance = balance;
            this.account = account;
            Initialize();
        }
        public SilverState(State state)
        {
            balance = state.balance;
            account = state.account;
        }
        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }
        public override bool Withdraw(double amount)
        {
            balance -= amount;
            StateChangeCheck();
            return true;
        }
        public override bool PayInterest()
        {
            balance += interest * balance;
            StateChangeCheck();
            return true;
        }
    }
}
