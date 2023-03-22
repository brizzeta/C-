using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._03.Build
{
    internal class Product
    {
        public string Frame { get; set; }
        public int Engine { get; set; }
        public int Wheel { get; set; }
        public string Transmission { get; set; }
        public override string ToString()
        {
            return $"Frame — {Frame}\nEngine - {Engine}\nWheel - {Wheel}\nTransmission - {Transmission}";
        }
    }
}
