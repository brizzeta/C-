namespace _29._03.Command
{
    internal class Program
    {
        static void Invoker(ICommand command, bool Undo)
        {
            // Invoker – это инициатор выполнения команды
            Controller controller = new Controller();
            controller.SetCommand(command);
            controller.PressButton();
            if (Undo)
                controller.PressUndo();
        }
        static void Main(string[] args)
        {
            TV tv = new TV(); // Receiver – конечный получатель команды
            ICommand command = new TVOnCommand(tv); // конкретная команда
            Invoker(command, true);

            Microwave microwave = new Microwave(); // Receiver – конечный получатель команды
            command = new MicrowaveCommand(microwave, 5000); // конкретная команда
            Invoker(command, false);
        }
    }
}
