using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03.File_HW
{
    internal class WriteFileReport
    {
        public void Write(IReport rep, string filename)
        {
            using(StreamWriter writer = new StreamWriter(filename+".txt"))
            {
                writer.Write(rep.report);
            }
        }
    }
}
