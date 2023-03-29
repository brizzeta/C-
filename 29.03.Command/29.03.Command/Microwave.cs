using System;
using System.Threading;

namespace _29._03.Command
{
    internal class Microwave
    {
        public void StartCooking(int time)
        {
            Console.WriteLine("Warming up food...");
            Thread.Sleep(time);
        }
        public void StopCooking()
        {
            Console.WriteLine("The food is warmed up!");
        }
    }
}
