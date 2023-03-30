using System.Collections.Generic;

namespace Mediator
{
    // The 'Mediator' abstract class
    internal abstract class AbstractChatroom
    {
	    public abstract void Register(Participant participant);
	    public abstract void Send(string from, string to, string message);
    };

    // The 'ConcreteMediator' class
    internal class Chatroom : AbstractChatroom
    {
        private Dictionary<string, Participant> participants;
        public Chatroom()
        {
            participants = new Dictionary<string, Participant>();
        }
        public override void Register(Participant participant)
        {
            var res = participants.ContainsKey(participant.Name);
            if (!res)
            {
                participants[participant.Name] = participant;
            }
            participant.Chatroom = this;
        }
        public override void Send(string from, string to, string message)
        {
            if (participants.TryGetValue(to, out Participant participant) && participant != null)
            {
                participant.Receive(from, message);
            }
        }
    };
}
