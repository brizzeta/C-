using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03.File_HW
{
    internal class ReportCountWord
    {
        public int Report(List<Poem> poems, string value)
        {
            int count = 0;
            foreach(Poem i in poems)
            {
                if (i.TextPoem.Contains(value))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
