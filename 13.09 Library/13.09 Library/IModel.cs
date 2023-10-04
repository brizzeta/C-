using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._09_Library
{
    internal interface IAuthor
    {
        string NameAutor { get; set; }
    }

    internal interface IBook
    {
        string NameBook { get; set; }
        Author AuthorBook { get; set; }
    }

    internal interface ILibrary
    {
        List<Book> Books { get; set; }
        List<Author> Authors { get; set; }

        void Save();
        void Load();
    }
}
