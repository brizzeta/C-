using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._04.Pattern_Visitor
{
    internal interface Element
    {
        void feature();
        void accept(Visitor v);
    }
    internal class Family : Element
    {
        public void feature()
        {
            Console.WriteLine("Medical feature");
        }
        public void accept(Visitor v)
        {
            v.visit(this);
        }
    }
    internal class Bank : Element
    {
        public void feature()
        {
            Console.WriteLine("Robbery feature");
        }
        public void accept(Visitor v)
        {
            v.visit(this);
        }
    }
    internal class Factory : Element
    {
        public void feature()
        {
            Console.WriteLine("Fire and flood feature");
        }
        public void accept(Visitor v)
        {
            v.visit(this);
        }
    }
}
