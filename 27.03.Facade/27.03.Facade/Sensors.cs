using System;

namespace _27._03.Facade
{
    internal class Sensors
    {
        public void CheckVoltage()
        {
            Console.WriteLine("Check voltage.");
        }
        public void TemperaturePowerUnit()
        {
            Console.WriteLine("Check temperature in power unit.");
        }
        public void TemperatureVideoCard()
        {
            Console.WriteLine("Check temperature in video card.");
        }
        public void TemperatureRAM()
        {
            Console.WriteLine("Check temperature in RAM.");
        }
        public void TemperatureAllSystems()
        {
            Console.WriteLine("Check temperature in all systems.");
        }
    }
}
