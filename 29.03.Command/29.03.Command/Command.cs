namespace _29._03.Command
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
    class TVOnCommand : ICommand
    {
	    private TV tv;
        public TVOnCommand(TV tvSet)
        {
           tv = tvSet;
        }
        public void Execute()
        {
            tv.On();
        }
        public void Undo()
        {
            tv.Off();
        }
    };
    class MicrowaveCommand : ICommand
    {
	    private Microwave microwave;
        private int time;
        public MicrowaveCommand(Microwave m, int t)
        {
            microwave = m;
            time = t;
        }
        public void Execute()
        {
            microwave.StartCooking(time);
            microwave.StopCooking();
        }
        public void Undo()
        {
            microwave.StopCooking();
        }
    };
}
