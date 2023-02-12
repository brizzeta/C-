using Library_name;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_books_name
{
    internal class My_books
    {
        Library[] lib;
        public My_books() => lib = new Library[0];
        public My_books(int size) => lib = new Library[size];
        public My_books(params Library[] arr)
        {
            lib = new Library[arr.Length];
            for (short i = 0; i < arr.Length; i++)
                lib[i] = arr[i];
        }
        public Library this[int index]
        {
            get
            {
                if (index >= 0 && index < lib.Length) 
                    return lib[index];
                else throw new Exception($"Index is NOT correct.");
            }
            set
            {
                if (index >= 0 && index < lib.Length) 
                    lib[index] = value;
                else throw new Exception($"Index is NOT correct.");
            }
        }
        public void AddBook(Library obj)
        {
            My_books NewBook = new My_books(lib.Length + 1);
            NewBook[lib.Length - 1] = obj;
        }
        public void DelBook(Library obj, int index)
        {
            for (int i = index; i < lib.Length; i++)
                (lib[i], lib[i + 1]) = (lib[i + 1], lib[i]);
            lib = new Library[lib.Length - 1];
        }
        public bool Find(Library obj, string FindName)
        {
            if (obj.name == FindName) 
                return true;
            else return false;
        }
    }
}
