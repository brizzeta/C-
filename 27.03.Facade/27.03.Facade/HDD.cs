using System;

namespace _27._03.Facade
{
    internal class HDD
    {
        public void Start() { Console.WriteLine("Start HDD."); }
        public void Stop() { Console.WriteLine("Stop HDD"); }
        public void BootSector() { Console.WriteLine("Boot sector check."); }
    }
}
