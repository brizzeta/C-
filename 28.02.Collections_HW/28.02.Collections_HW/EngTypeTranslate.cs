using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._02.Collections_HW
{
    internal interface ITypeTranslate
    {
        string Type(string word);
    }
    internal class EngTypeTranslate : ITypeTranslate
    {
        EngRusDictionary list;
        public EngTypeTranslate(EngRusDictionary list)
        {
            this.list = list;
        }
        public string Type(string word)
        {
            for (int i = 0; i < list.CountList; i++)
            {
                if (list.GetList(i).Item1.Contains(word))
                {
                    return list.GetList(i).Item2;
                }
            }
            return "No translate";
        }
    }
    internal class RusTypeTranslate : ITypeTranslate
    {
        EngRusDictionary list;
        public RusTypeTranslate(EngRusDictionary list)
        {
            this.list = list;
        }
        public string Type(string word)
        {
            for (int i = 0; i < list.CountList; i++)
            {
                if (list.GetList(i).Item2.Contains(word))
                {
                    return list.GetList(i).Item1;
                }
            }
            return "No translate";
        }
    }
}
