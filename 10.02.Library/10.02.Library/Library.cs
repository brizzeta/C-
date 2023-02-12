using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_name
{
    class Library
    {
        string name, author;
        int pages;
        public Library()
        {
            name = author = string.Empty;
            pages = 0;
        }
        internal Library(Library obj)
        {
            this.name = obj.name;
            this.author = obj.author;
            this.pages = obj.pages;
        }
        public string BookName
        {
            get => name;
            set => name = value;
        }
        public string AuthorName
        {
            get => author;
            set => author = value;
        }
        public int Pages
        {
            get => pages;
            set => pages = value;
        }
        internal void Input()
        {
            Console.Write("Enter name of book: ");
            name = Console.ReadLine();
            Console.Write("Enter author name: ");
            author = Console.ReadLine();
            Console.Write("Enter page count: ");
            pages = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        public override string ToString()
        {
            return $"Name of book: {name}\nName of author: {author}\nPages: {pages}";
        }
    }
}
