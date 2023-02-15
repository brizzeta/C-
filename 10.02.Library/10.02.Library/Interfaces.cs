using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_name
{
    interface IComperable
    {
        int CompareTo(object obj);
    }
    interface IComparer
    {
        int Compare(object obj1, object obj2);
    }
    interface IClone
    {
        object Clone();
    }
}
