using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._04.Pattern_Visitor
{
    internal interface Visitor
    {
        void visit(Family el);
        void visit(Bank el);
        void visit(Factory el);
    }
    internal class ConcreteVisitors : Visitor
    {
        public void visit(Family el)
        {
            el.feature();
        }
        public void visit(Bank el)
        {
            el.feature();
        }
        public void visit(Factory el)
        {
            el.feature();
        }
    }
}
