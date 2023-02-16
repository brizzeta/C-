using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _13._02._2023.Inheritance {
    internal class Program {
        static void Main(string[] args) {
            Figure[] ptr = new Figure[4];
            ptr[0] = new Rectangle();
            ptr[1] = new Circle();
            ptr[2] = new RightTriangle();
            ptr[3] = new Trapezoid();
        }
    }
}
