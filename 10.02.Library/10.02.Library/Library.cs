using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces_name;

namespace Library_name
{
    class Library : IComparable, IClone
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Cathegory { get; set; }
        public int Pages { get; set; }
        public Library(string name, string author, string cathegory, int pages)
        {
            Name = name;
            Author = author;
            Cathegory = cathegory;
            Pages = pages;
        }
        public Library()
        {
            Name = Author = Cathegory = string.Empty;
            Pages = 0;
        }
        internal Library(Library obj)
        {
            this.Name = obj.Name;
            this.Author = obj.Author;
            this.Cathegory = obj.Cathegory;
            this.Pages = obj.Pages;
        }
        internal void Input()
        {
            Console.Write("Enter name of book: ");
            Name = Console.ReadLine();
            Console.Write("Enter author name: ");
            Author = Console.ReadLine();
            Console.Write("Enter page count: ");
            Pages = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        public override string ToString()
        {
            return $"Name of book: {Name}\nName of author: {Author}\nCathegory {Cathegory}\nPages: {Pages}";
        }
        public int CompareTo(object obj)
        {
            if(obj is Library)
                return Name.CompareTo(((Library)obj).Name);
            throw new NotImplementedException();
        }
        public class SortByName : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                if (x is Library && y is Library)
                    return (x as Library).Name.CompareTo((y as Library).Name);
                throw new NotImplementedException();
            }
        }
        public class SortByCathegory : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                if (x is Library && y is Library)
                    return (x as Library).Cathegory.CompareTo((y as Library).Cathegory);
                throw new NotImplementedException();
            }
        }
        public object Clone()
        {
            return new Library(Name, Author, Cathegory, Pages);
        }
    }
}
