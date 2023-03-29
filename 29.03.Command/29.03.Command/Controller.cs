namespace _29._03.Command
{
    internal class Controller
    {
        private ICommand command;
        public Controller() { }
        public void SetCommand(ICommand com)
        {
            command = com;
        }
        public void PressButton()
        {
            if (command != null)
                command.Execute();
        }
        public void PressUndo()
        {
            if (command != null)
                command.Undo();
        }
    }
}
