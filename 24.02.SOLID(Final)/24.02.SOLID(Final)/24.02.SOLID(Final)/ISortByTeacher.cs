using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_02_SOLID_Final
{
    internal interface ISortByTeacher : IComparer
    {
    }

    internal class SortTeacherByNS : ISortByTeacher
    {
        public int Compare(object x, object y)
        {
            if (x is Teacher && y is Teacher)
            {
                return (x as Teacher).ns.CompareTo((y as Teacher).ns);
            }
            throw new NotImplementedException();
        }
    }

    internal class SortTeacherByGroup : ISortByTeacher
    {
        public int Compare(object x, object y)
        {
            if (x is Teacher && y is Teacher)
            {
                return (x as Teacher).Group.CompareTo((y as Teacher).Group);
            }
            throw new NotImplementedException();
        }
    }

    internal class SortTeacherByDepartment : ISortByTeacher
    {
        public int Compare(object x, object y)
        {
            if (x is Teacher && y is Teacher)
            {
                return (x as Teacher).Departments.CompareTo((y as Teacher).Departments);
            }
            throw new NotImplementedException();
        }
    }
}
