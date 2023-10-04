using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml;

namespace _13._09_Library
{
    public class Author : IAuthor
    {
        public string NameAutor { get; set; }

        public Author() 
        { 
            NameAutor = string.Empty;
        }
    }

    public class Book : IBook
    {
        public string NameBook { get; set; }
        public Author AuthorBook { get; set; }

        public Book()
        {
            NameBook = string.Empty;
            AuthorBook = new Author();
        }
    }


    [Serializable]
    public class LibraryData
    {
        public List<Author> Authors { get; set; }
        public List<Book> Books { get; set; }
    }

    internal class Library : ILibrary
    {
        public List<Book> Books { get; set; }
        public List<Author> Authors { get; set; }

        public Library()
        {
            Books = new List<Book>();
            Authors = new List<Author>();
        }

        public void Save() 
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("LibrarySave.xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(LibraryData));
                    LibraryData data = new LibraryData { Authors = Authors, Books = Books };
                    serializer.Serialize(writer, data);
                }
            }
            catch (Exception ex)
            {
            }
        }
        public void Load()
        {
            try
            {
                if (File.Exists("LibrarySave.xml"))
                {
                    using (StreamReader reader = new StreamReader("LibrarySave.xml"))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(LibraryData));
                        LibraryData data = (LibraryData)serializer.Deserialize(reader);
                        Authors = data.Authors;
                        Books = data.Books;
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
