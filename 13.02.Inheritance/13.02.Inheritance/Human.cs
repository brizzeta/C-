using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02.Inheritance
{
    abstract class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Human() : this("Human", 0) { }
        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}";
        }
        public virtual void Print()
        {
            System.Console.WriteLine($"Name: {Name}\nAge: {Age}");
        }
    }
    class Student : Human 
    {
        public string University { get; set; }
        public Student(string name, int age, string university) : base(name, age)
        {
            University = university;
        }
        public override string ToString()
        {
            return base.ToString() + $"University: {University}";
        }
        public override void Print()
        {
            System.Console.WriteLine($"Name: {Name}\nAge: {Age}\nUniversity: {University}");
        }
    }
    class Teacher : Human
    {
        public string University { get; set; }
        public Teacher(string name, int age, string university) : base(name, age)
        {
            University = university;
        }
        public override string ToString()
        {
            return base.ToString() + $"University: {University}";
        }
        public override void Print()
        {
            System.Console.WriteLine($"Name: {Name}\nAge: {Age}\nUniversity: {University}");
        }
    }
}
