using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._2023.Inheritance {
    internal abstract class Device {
        internal abstract void Show();
        internal abstract void Desc();
        internal abstract void Sound();
    }
    internal class Kettle : Device {
        internal override void Show() => Console.WriteLine("Kettle.");
        internal override void Desc() => Console.WriteLine("Description: allows you to boil water.");
        internal override void Sound() => Console.WriteLine("Shhhhhhhhhhh.");
    }
    internal class Car : Device {
        internal override void Show() => Console.WriteLine("Car.");
        internal override void Desc() => Console.WriteLine("Description: allows you to quickly get to the right place.");
        internal override void Sound() => Console.WriteLine("brrr-brrrr.");
    }
    internal class Steamer : Device {
        internal override void Show() => Console.WriteLine("Steamer.");
        internal override void Desc() => Console.WriteLine("Description: allows you to get to anothe side of sea or ocean.");
        internal override void Sound() => Console.WriteLine("tooo-tooo.");
    }
}
