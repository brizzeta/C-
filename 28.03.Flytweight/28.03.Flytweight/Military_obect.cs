using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._03.Flytweight
{
    internal class Military_objects
    {
        Military_obect[] obj;
        public Military_objects(int count)
        {
            obj = new Military_obect[count];
        }
        public Military_obect GetMilitary_Obect(string picture, double speed, double power)
        {
            foreach (Military_obect i in obj) 
            {
                if (i.Picture == picture && i.Speed == speed && i.Power == power)
                {
                    return i;
                }
            }
            return new Military_obect(picture, speed, power);
        }
    }
    internal class Military_obect
    {
        public string Picture { get; set; }
        public double Speed { get; set; }
        public double Power { get; set; }
        public Military_obect(string picture, double speed, double power)
        {
            Picture = picture;
            Speed = speed;
            Power = power;
        }
        public void Show(double position)
        {
            Console.WriteLine($"Picture: {Picture}\nSpeed: {Speed}\nPower: {Power}");
        }
        public void operation(double speed, double power)
        {
            Speed = speed;
            Power = power;
        }
    }
}
