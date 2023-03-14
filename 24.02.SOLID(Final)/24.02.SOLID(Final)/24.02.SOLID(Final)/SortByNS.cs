using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_02_SOLID_Final
{
    internal class SortByNS : ISort
    {
        public int Compare(object x, object y)
        {
            if (x is Student && y is Student)
            {
                return (x as Student).ns.CompareTo((y as Student).ns);
            }
            throw new NotImplementedException();
        }
    }
}
