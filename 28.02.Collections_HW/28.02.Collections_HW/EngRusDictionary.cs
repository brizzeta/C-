using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._02.Collections_HW
{
    internal class EngRusDictionary
    {
        List<Tuple<string, string>> dictionary;
        int count;

        public EngRusDictionary()
        {
            dictionary = new List<Tuple<string, string>>();
            count = dictionary.Count;
        }
        public Tuple<string, string> GetList(int i)
        {
            if (i < 0 || i >= count)
            {
                throw new Exception("Out of list");
            }
            return dictionary[i];
        }
        public int CountList
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }
        public void AddList(string valueEng, string valueRus)
        {
            dictionary.Add(Tuple.Create(valueEng, valueRus));
            count = dictionary.Count;
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < dictionary.Count; i++)
            {
                yield return dictionary[i].Item1 + " " + dictionary[i].Item2;
            }
        }
    }
}
