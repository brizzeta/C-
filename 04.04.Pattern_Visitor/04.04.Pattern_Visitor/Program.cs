using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._04.Pattern_Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Element el = new Family();
            el.accept(new ConcreteVisitors());
        }
    }
}
