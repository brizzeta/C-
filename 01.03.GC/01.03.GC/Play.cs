using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _01._03.GC
{
    internal class Play : IDisposable
    {
        public string Name { get; set; }
        public string Full_name { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public Play(string name, string full_name, string genre, int year)
        {
            Name = name;
            Full_name = full_name;
            Genre = genre;
            Year = year;
        }
        public override string ToString() => $"Name: {Name}\nFull name: {Full_name}\nGenre: {Genre}\nYear: {Year}";
        public void Dispose()
        {
            Name = null;
            Full_name = null;
            Genre = null;
            Year = 0;
        }
        ~Play()
        {
            Name = null;
            Full_name = null;
            Genre = null;
            Year = 0;
        }
    }
}
