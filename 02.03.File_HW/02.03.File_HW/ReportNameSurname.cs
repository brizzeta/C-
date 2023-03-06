using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03.File_HW
{
    internal class ReportNameSurname : IReport
    {
        public string report
        {
            get; set;
        }

        public string Report(List<Poem> poems)
        {
            foreach(Poem poem in poems)
            {
                report += "Name surname -> " + poem.NameSurname + "\n";
            }
            return report;
        }
    }
}
