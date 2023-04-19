using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._03.Flytweight
{
    internal class Program
    {
        internal class Context
        {
            public double Speed { get; set; }
            public double Power { get; set; }
            Military_obect obj;
            Military_objects objs;
            public Context(int count) 
            {
                objs = new Military_objects(count);
            }
            public Context(double speed, double power, string picture)
            {
                Speed = speed;
                Power = power;
                obj = objs.GetMilitary_Obect(picture, speed, power);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
