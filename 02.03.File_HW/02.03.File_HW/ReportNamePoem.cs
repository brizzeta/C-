using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03.File_HW
{
    internal class ReportNamePoem : IReport
    {
        public string report
        {
            get; set;
        }

        public string Report(List<Poem> poems)
        {
            foreach(Poem i in poems)
            {
                report += "Name Poem -> " + i.NamePoem + "\n";
            }
            return report;
        }
    }
}
