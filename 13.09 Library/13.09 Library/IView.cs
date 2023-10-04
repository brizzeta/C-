using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._09_Library
{
    internal interface IView
    {
        event Action<string> AddAuthor;
        event Action<string, string> AddBook;
        event Action<string> Filter;
        event Action<string> DeleteAuthor;
        event Action<string, string> EditAuthor;
        event Action<string, string> EditBook;
        event Action<string> DeleteBook;
        event EventHandler<EventArgs> Save;
        event EventHandler<EventArgs> Load;

        void DisplayAuthors(List<string> authors);
        void DisplayBooks(List<string> books);
        void DisplayFiltered(List<string> books);

        void Error(string message);
    }
}
