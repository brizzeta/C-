using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._2023.Inheritance {
    internal abstract class Figure {
        internal abstract double FindArea();
    }
    internal class Rectangle : Figure {
        internal double A { get; set; }
        internal double B { get; set; }
        public Rectangle() :this(0.0, 0.0) { }
        public Rectangle(double a, double b) {
            A = a;
            B = b;
        }
        internal override double FindArea() { return A * B; }
    }
    internal class Circle : Figure {
        internal double Radius { get; set; }
        public Circle() : this(0.0) { }
        public Circle(double radius) => Radius = radius;
        internal override double FindArea() { return Math.PI * Math.Pow(Radius, 2); }
    }
    internal class RightTriangle : Figure {
        internal double A { get; set; }
        internal double B { get; set; }
        public RightTriangle() : this(0.0, 0.0) { }
        public RightTriangle(double a, double b) {
            A = a;
            B = b;
        }
        internal override double FindArea() { return (A * B) / 2; }
    }
    internal class Trapezoid : Figure {
        internal double A { get; set; }
        internal double B { get; set; }
        internal double Height { get; set; }
        public Trapezoid() : this(0.0, 0.0, 0.0) { }
        public Trapezoid(double a, double b, double height) {
            A = a;
            B = b;
            Height = height;
        }
        internal override double FindArea() { return (0.5 * (A + B)) * Height; }
    }
}
