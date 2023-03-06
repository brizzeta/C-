using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03.File_HW
{
    internal class Poem
    {
        string namepoem;
        string NS;
        int year;
        string textpoem;
        string theampoem;

        public Poem()
        {
            namepoem = string.Empty;
            NS = string.Empty;
            year = 0;
            textpoem = string.Empty;
            theampoem = string.Empty;
        }

        public Poem(string namepoem, string nS, int year, string textpoem, string theampoem)
        {
            this.namepoem = namepoem;
            NS = nS;
            this.year = year;
            this.textpoem = textpoem;
            this.theampoem = theampoem;
        }

        public string NamePoem
        {
            get { return namepoem; }
            set { namepoem = value; }
        }

        public string NameSurname
        {
            get { return NS; }
            set { NS = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public string TextPoem
        {
            get { return textpoem; }
            set { textpoem = value; }
        }

        public string TheamPoem
        {
            get { return theampoem; }
            set { theampoem = value; }

        }
    }
}
