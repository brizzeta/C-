using System;

namespace Mediator
{
    // The 'Colleague' abstract class
    internal abstract class Participant
    {
        public AbstractChatroom Chatroom { get; set; }
        public string Name { get; set; }
        public Participant(string name)
        {
            Name = name;
        }
        public void Send(string to, string message)
        {
            Chatroom.Send(Name, to, message);
        }
        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"{from} to {Name}: '{message}'");
        }
};
}
