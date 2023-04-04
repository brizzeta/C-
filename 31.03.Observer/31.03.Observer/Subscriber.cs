using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._03.Observer
{
    internal interface Subscriber
    {
        void Notify();
    }
    internal class ConcreteSubscriber : Subscriber
    {
        public void Notify()
        {
            Console.WriteLine("New phone!");
        }
    }
}
