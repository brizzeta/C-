namespace Mediator
{
    internal class Program
    {
        static void registration(AbstractChatroom chatroom, Participant[] participants, int size)
        {
            for (int i = 0; i < size; i++)
                chatroom.Register(participants[i]);
        }

        static void chat(Participant participants, string to, string message)
        {
            participants.Send(to, message);
        }

        static void Main(string[] args)
        {
            AbstractChatroom chatroom = new Chatroom();

            Participant[] participants = {
                new Beatles("George"),
                new Beatles("Paul"),
                new Beatles("Ringo"),
                new Beatles("John"),
                new NonBeatles("Yoko")
            };
            registration(chatroom, participants, 5);

            chat(participants[4], "John", "Hi John!");
            chat(participants[1], "Ringo", "All you need is love");
            chat(participants[2], "George", "My sweet Lord");
            chat(participants[1], "John", "Can't buy me love");
            chat(participants[3], "Yoko", "My sweet love");
        }
    }
}
