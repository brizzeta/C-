namespace Storage_dll
{
    [Serializable]
    public class Flash : Storage
    {
        public double USB_Speed { get; set; }
        public Flash() : base()
        { 
            USB_Speed = 0;
        }
        public Flash(string Manufacturer, string Name, string Model, int Capacity, int Count, double USB_Speed) : base(Manufacturer, Name, Model, Capacity, Count)
        {
            this.USB_Speed = USB_Speed;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("USB speed: " + USB_Speed + "\n");
        }
    }
    [Serializable]
    public class HDD : Storage
    {
        public double Spindle_Speed { get; set; }
        public HDD() : base()
        {
            Spindle_Speed = 0;
        }
        public HDD(string Manufacturer, string Name, string Model, int Capacity, int Count, double Spindle_Speed) : base(Manufacturer, Name, Model, Capacity, Count)
        {
            this.Spindle_Speed = Spindle_Speed;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Spindle speed: " + Spindle_Speed + "\n");
        }
    }
    [Serializable]
    public class DVD : Storage
    {
        public double Write_Speed { get; set; }
        public DVD() : base() 
        { 
            Write_Speed = 0;
        }
        public DVD(string Manufacturer, string Name, string Model, int Capacity, int Count, double Write_Speed) : base(Manufacturer, Name, Model, Capacity, Count)
        {
            this.Write_Speed = Write_Speed;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Write speed: " + Write_Speed + "\n");
        }
    }
}
