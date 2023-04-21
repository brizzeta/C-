using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._04.Pattern_Strategy
{
    internal interface Strategy
    {
        void execute(string strat);
    }
    internal class ConcreteStrategy : Strategy
    {
        double time;
        public void execute(string strat) 
        { 
            switch(strat)
            {
                case "Bicycle":
                    time = 30;
                    break;
                case "Bus":
                    time = 15;
                    break;
                case "Taxi":
                    time = 10;
                    break;
            }
            Console.WriteLine("Time to airport: ", time);
        }
    }
}
