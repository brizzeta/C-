using System;

namespace _27._03.Facade
{
    internal class CardReader
    {
        public void Start() { Console.WriteLine("Start card reader."); }
        public void OriginalPosition() { Console.WriteLine("Return to original position."); }
        public void CheckDiskPresence() { Console.WriteLine("Disk presence check."); }
    }
}
