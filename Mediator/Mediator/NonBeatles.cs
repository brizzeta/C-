using System;

namespace Mediator
{
    //ConcreteColleague class
    internal class NonBeatles : Participant
    {
        public NonBeatles(string name) : base(name) { }
        public override void Receive(string from, string message)
        {
            Console.Write("To a non-Beatles: ");
            base.Receive(from, message);
        }
    }
}
