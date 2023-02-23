using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._02.Anonym_method
{
    internal class Program
    {
        delegate bool del1(int x);
        static void Laboratory()
        {
            del1 myDel1 = delegate (int x)
            {
                return x % 2 == 0;
            };
        }
        static void Main(string[] args)
        {

        }
    }
}
