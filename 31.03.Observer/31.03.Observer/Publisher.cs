using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._03.Observer
{
    internal class Publisher
    {
        private List<Subscriber> subscribers;
        public bool NewPhone { get; set; } = false;
        public Publisher() 
        {
            subscribers = new List<Subscriber>();
        }
        public void Subscribe(Subscriber subscriber)
        {
            subscribers.Add(subscriber);
        }
        public void Unsubscribe(Subscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }
        public void NotifySubscribers()
        {
            foreach (Subscriber subscriber in subscribers)
            {
                subscriber.Notify();
            }
        }
        public void MainBussinesLogic()
        {
            NewPhone = true;
            NotifySubscribers();
        }
    }
}
