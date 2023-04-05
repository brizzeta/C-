using System;

namespace _27._03.Facade
{
    internal class PowerUnit
    {
        public void Supply()
        {
            Console.WriteLine("Power supply.");
        }
        public void SupplyVideoCard()
        {
            Console.WriteLine("Power supply on video card.");
        }
        public void SupplyRAM()
        {
            Console.WriteLine("Power supply on RAM.");
        }
        public void SupplyCardReader()
        {
            Console.WriteLine("Power supply on card reader.");
        }
        public void SupplyHDD()
        {
            Console.WriteLine("Power supply on HDD.");
        }
        public void StopSupplyVideoCard()
        {
            Console.WriteLine("Stop power supply on video card.");
        }
        public void StopSupplyRAM()
        {
            Console.WriteLine("Stop power supply on RAM.");
        }
        public void StopSupplyCardReader()
        {
            Console.WriteLine("Stop power supply on card reader.");
        }
        public void StopSupplyHDD()
        {
            Console.WriteLine("Stop power supply on HDD.");
        }
        public void StopSupply()
        {
            Console.WriteLine("Stop power supply.");
        }
    }
}
