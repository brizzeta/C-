using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03.File_HW
{
    internal class CollectionPoem
    {
        List<Poem> list;

        public CollectionPoem()
        {
            list = new List<Poem>();
        }

        public CollectionPoem(Poem list)
        {
            this.list.Add(list);
        }

        public List<Poem> GetList()
        {
            return list;
        }

        public void Add(Poem poem)
        {
            list.Add(poem);
        }

        public void Delete(Poem poem)
        {
            list.Remove(poem);
        }

        public void Change(Poem poem)
        {
            Poem poem2 = list.FirstOrDefault(def => def.NameSurname == poem.NameSurname);
            if (poem2 != null)
            {
                poem2.NameSurname = poem.NameSurname;
                poem2.TheamPoem = poem.TheamPoem;
                poem2.Year = poem.Year;
                poem2.TextPoem = poem.TextPoem;
                poem2.NamePoem = poem.NamePoem;
            }
        }

        public List<Poem> SearchByYear(int year)
        {
            return list.Where(find => find.Year == year).ToList();
        }

        public List<Poem> SearchByNameSurname(string NS)
        {
            return list.Where(find => find.NameSurname == NS).ToList();
        }

        public List<Poem> SearchByNamePoem(string namepoem)
        {
            return list.Where(find => find.NamePoem == namepoem).ToList();
        }

        public List<Poem> SearchByTheamPoem(string theam)
        {
            return list.Where(find => find.TheamPoem == theam).ToList();
        }

        public void LoadFile()
        {
            using(StreamReader read = new StreamReader("Poem.txt"))
            {
                while (!read.EndOfStream)
                {
                    string NS = read.ReadLine();
                    string name = read.ReadLine();
                    int year = int.Parse(read.ReadLine());
                    string theam = read.ReadLine();
                    string text = read.ReadLine();
                    list.Add(new Poem(name, NS, year, text, theam));
                }
            }
        }

        public void WriteFile()
        {
            using (StreamWriter write = new StreamWriter("PoemSave.txt"))
            {
                foreach(Poem poem in list)
                {
                    write.WriteLine(poem.NameSurname);
                    write.WriteLine(poem.NamePoem);
                    write.WriteLine(poem.Year);
                    write.WriteLine(poem.TheamPoem);
                    write.WriteLine(poem.TextPoem);
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }
    }
}
