using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._2023.Inheritance {
    internal abstract class Worker {
        internal abstract void Print();
    }
    internal class President : Worker {
        internal override void Print() => Console.WriteLine("Very responsible job.");
    }
    internal class Security : Worker {
        internal override void Print() => Console.WriteLine("Protects a person.");
    }
    internal class Manager : Worker {
        internal override void Print() => Console.WriteLine("Production, administrator, organizer.");
    }
    internal class Engineer : Worker {
        internal override void Print() => Console.WriteLine("A specialist who is engaged in the creation and maintenance of a variety of technical devices.");
    }
}
