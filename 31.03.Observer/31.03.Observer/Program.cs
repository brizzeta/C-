using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._03.Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriberA = new ConcreteSubscriber();
            Subscriber subscriberB = new ConcreteSubscriber();
            publisher.Subscribe(subscriberA);
            publisher.Subscribe(subscriberB);
            publisher.MainBussinesLogic();
        }
    }
}
