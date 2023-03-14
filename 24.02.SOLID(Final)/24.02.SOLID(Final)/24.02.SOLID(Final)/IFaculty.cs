using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_02_SOLID_Final
{
    internal interface IFaculty
    {
        string Name { get; }
        List<IDepartment> departments { get; }
        List<Student> students { get; }
        void ChooseFaculty();
    }
}
