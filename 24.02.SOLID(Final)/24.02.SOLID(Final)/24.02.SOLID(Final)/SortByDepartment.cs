using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_02_SOLID_Final
{
    internal class SortByDepartment : ISort
    {
        public int Compare(object x, object y)
        {
            if (x is Student && y is Student)
            {
                return (x as Student).Department.CompareTo((y as Student).Department);
            }
            throw new NotImplementedException();
        }
    }
}
