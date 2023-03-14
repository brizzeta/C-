using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_02_SOLID_Final
{
    internal interface IDepartment
    {
        void Lesson();
        Teacher Head { get; }
        List<Teacher> Teachers { get; }
    }
}
