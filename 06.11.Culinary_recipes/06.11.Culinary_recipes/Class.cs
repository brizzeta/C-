using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace _06._11.Culinary_recipes
{
    internal class Class : INotifyPropertyChanged
    {
        public string Header { get; set; }
        public string Paragraph1 { get; set; }
        public string Paragraph2 { get; set; }
        public string Image { get; set; }
        public Class()
        {
            Header = string.Empty;
            Paragraph1 = string.Empty;
            Paragraph2 = string.Empty;
            Image = string.Empty;
        }
        public Class(string header, string paragraph1, string paragraph2, string image)
        {
            Header = header;
            Paragraph1 = paragraph1;
            Paragraph2 = paragraph2;
            Image = image;
        }
    }
}
