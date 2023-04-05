using System;

namespace _27._03.Facade
{
    internal class VideoCard
    {
        public void Start() { Console.WriteLine("Start video card."); }
        public void ConnectMonitor() { Console.WriteLine("Monitor connection check."); }
        public void DataRAM() { Console.WriteLine("RAM Data."); }
        public void DataCardReader() { Console.WriteLine("Card reader Data."); }
        public void DataHDD() { Console.WriteLine("HDD Data."); }
        public void Stop() { Console.WriteLine("Stop video card."); }
    }
}
