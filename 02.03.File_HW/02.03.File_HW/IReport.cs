using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03.File_HW
{
    internal interface IReport
    {
        string report { get; }
        string Report(List<Poem> poems);
    }
}
