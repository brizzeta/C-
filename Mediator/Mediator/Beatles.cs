using System;

namespace Mediator
{
    internal class Beatles : Participant
    {
        public Beatles(string name) : base(name) { }
        public override void Receive(string from, string message)
        {
            Console.Write("To a Beatles: ");
            base.Receive(from, message);
        }
    }
}
