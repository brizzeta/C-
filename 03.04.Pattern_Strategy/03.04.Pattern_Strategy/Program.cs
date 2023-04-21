using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._04.Pattern_Strategy
{
    internal class Program
    {
        internal class Context
        {
            public Strategy strategy { get;  set; }
            public void Time(string strat)
            {
                strategy.execute(strat);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
