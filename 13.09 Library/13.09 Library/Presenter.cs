using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._09_Library
{
    internal class Presenter
    {
        private readonly IView view;
        private Library model;

        public Presenter(IView view)
        {
            this.view = view;
            model = new Library();
            view.AddAuthor += AddAutor;
            view.AddBook += AddBook;
            view.Filter += FilterBook;
            view.DeleteAuthor += DeleteAuthor;
            view.EditAuthor += EditAuthor;
            view.EditBook += EditBook;
            view.DeleteBook += DeleteBook;
            view.Save += new EventHandler<EventArgs>(Save);
            view.Load += new EventHandler<EventArgs>(Load);
        }

        private void Save(object sender, EventArgs e)
        {
            model.Save();
        }

        private void Load(object sender, EventArgs e)
        {
            model.Load();
            Update();
        }

        private void FilterBook(string name)
        {
            if (name != null)
            {
                var filteredBooks = model.Books.Where(i => i.AuthorBook.NameAutor == name).Select(i => i.NameBook).ToList();
                view.DisplayFiltered(filteredBooks);
            }
            else
            {
                Update();
            }
        }

        private void Update()
        {
            List<string> authors = new List<string>();
            foreach (var i in model.Authors)
            {
                authors.Add(i.NameAutor);
            }
            view.DisplayAuthors(authors);
            List<string> books = new List<string>();
            foreach(var i in model.Books)
            {
                books.Add(i.NameBook);
            }
            view.DisplayBooks(books);
        }

        private void AddAutor(string name)
        {
            if (model.Authors.Find(i => i.NameAutor == name) != null)
            {
                view.Error("Ошибка! Автор с таким именем существует!");
            }
            else 
            {
                Author authortemp = new Author();
                authortemp.NameAutor = name;
                model.Authors.Add(authortemp);
                Update();
            }
        }

        private void AddBook(string NameAutor,string BookName) 
        {
            Author author1 = model.Authors.FirstOrDefault(i => i.NameAutor == NameAutor);
            if(author1 != null)
            {
                Book bookstemp = new Book { NameBook = BookName, AuthorBook = author1 };
                model.Books.Add(bookstemp);
            }
            else 
            {
                view.Error("Ошибка! Вы не можете добавить книгу к автору которого нету в списке!");
            }
            Update();
        }

       private void EditAuthor(string oldname, string newname) 
        {
            Author authortemp = model.Authors.FirstOrDefault(i => i.NameAutor == oldname);
            if(authortemp != null)
            {
                authortemp.NameAutor = newname;
                foreach(Book i in model.Books.Where(i => i.AuthorBook.NameAutor == oldname))
                {
                    i.AuthorBook.NameAutor = newname;
                }
            }
            else 
            {
                view.Error("Такого автора не существует!");
            }
            Update();
        }

       private void DeleteAuthor(string authorname)
        {
            Author authortemp = model.Authors.FirstOrDefault(i => i.NameAutor == authorname);
            if(authortemp != null)
            {
                model.Authors.Remove(authortemp);
                model.Books.RemoveAll(i => i.AuthorBook.NameAutor == authorname);

            }
            Update();
        }

        private void EditBook(string oldname, string newname) 
        {
            Book booktemp = model.Books.FirstOrDefault(i => i.NameBook == oldname);
            if (booktemp != null)
            {
                booktemp.NameBook = newname;
            }
            else 
            {
                view.Error("Ошибка! Такой книги не существует!");
            }
            Update();
        }

        private void DeleteBook(string name)
        {
            Book booktemp = model.Books.FirstOrDefault(i => i.NameBook == name);
            if(booktemp != null)
            {
                model.Books.Remove(booktemp);
                
            }
            Update();
        }
    }
}
