using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_02_SOLID_Final
{
    internal class NonProfileDepartment : IDepartment
    {
        string lesson;

        public NonProfileDepartment()
        {
            lesson = string.Empty;
        }

        public NonProfileDepartment(string lesson)
        {
            this.lesson = lesson;
        }

        public void Lesson()
        {
            Console.WriteLine("Enter non profile department lesson which you spend");
            lesson = Console.ReadLine();
        }

        public Teacher Head { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
