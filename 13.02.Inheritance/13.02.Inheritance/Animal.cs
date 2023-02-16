using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._2023.Inheritance {
    internal class Animal {
        internal string Name { get; set; }
        internal string Description { get; set; }
        internal int Height { get; set; }
        internal int Width { get; set; }
        internal Animal() :this(null, null, 0, 0) { }
        internal Animal(string name, string desc, int height, int width) {
            Name = name;
            Description = desc;
            Height = height;
            Width = width;
        }
        internal virtual void Print() => Console.WriteLine($"Animal: {Name}\nDescription: {Description}\n" +
            $"Height: {Height}\nWidth: {Width}\n");
        public override string ToString() => $"Animal: {Name}\nDescription: {Description}\n" +
            $"Height: {Height}\nWidth: {Width}\n";
    }
    internal class Tiger : Animal {
        internal int Speed { get; set; }
        internal Tiger(string name, string desc, int height, int width, int speed) 
            :base(name, desc, height, width) => Speed = speed;
        internal override void Print() {
            base.Print();
            Console.WriteLine($"Running score: {Speed}");
        }
        public override string ToString() => base.ToString() + $"Running score: {Speed}";
    }
    internal class Crocodile : Animal {
        internal int BiteStrength { get; set; }
        internal Crocodile(string name, string desc, int height, int width, int bite)
            : base(name, desc, height, width) => BiteStrength = bite;
        internal override void Print() {
            base.Print();
            Console.WriteLine($"Bite force: {BiteStrength}");
        }
        public override string ToString() => base.ToString() + $"Bite force: {BiteStrength}";
    }
    internal class Kangaroo : Animal {
        internal int JumpHeight { get; set; }
        internal Kangaroo(string name, string desc, int height, int width, int jump)
            : base(name, desc, height, width) => JumpHeight = jump;
        internal override void Print() {
            base.Print();
            Console.WriteLine($"Jump height: {JumpHeight}");
        }
        public override string ToString() => base.ToString() + $"Jump height: {JumpHeight}";
    }
}
