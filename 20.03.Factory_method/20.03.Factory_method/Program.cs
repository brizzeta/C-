using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._03.Factory_method
{
    internal class Program
    {
        internal class Logistic
        {
            public void Logic(Creator obj) 
            {
                obj.Create();
            }
        }
        static void Main(string[] args)
        {
            Logistic a = new Logistic();
            a.Logic(new CreateRoadLogistic());
        }
    }
}
