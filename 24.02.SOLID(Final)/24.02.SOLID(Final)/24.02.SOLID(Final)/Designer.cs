using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_02_SOLID_Final
{
    internal class Designer : IFaculty
    {
        public string Name
        {
            get; set;
        }

        public List<IDepartment> departments { get; set; }

        public List<Student> students { get; set; }

        public void ChooseFaculty()
        {
            Name = "Designer";
        }
    }
}
