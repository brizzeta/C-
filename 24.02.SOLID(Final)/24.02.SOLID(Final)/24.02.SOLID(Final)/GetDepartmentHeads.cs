using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_02_SOLID_Final
{
    internal class GetDepartmentHeads
    {
        public List<Teacher> Get(List<IDepartment> dep)
        {
            List<Teacher> heads = new List<Teacher>();
            foreach (IDepartment department in dep)
            {
                if(department.Head != null)
                {
                    heads.Add(department.Head);
                }
            }
            return heads;
        }

    }
}
