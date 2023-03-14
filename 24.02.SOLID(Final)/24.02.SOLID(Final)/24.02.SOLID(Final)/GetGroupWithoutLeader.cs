using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _24_02_SOLID_Final
{
    internal class GetGroupWithoutLeader
    {
        public void Get(University uni)
        {
            List<Group> groupsWithoutHead = new List<Group>();
            foreach (IFaculty faculty in uni.Faculties)
            {
                foreach (IDepartment department in faculty.Department)
                {
                    foreach (Group group in department.Groups)
                    {
                        if (group.GroupHead == null)
                        {
                            groupsWithoutHead.Add(group);
                        }
                    }
                }
            }
            List<IDepartment> departmentsWithoutHead = new List<IDepartment>();
            foreach (IFaculty faculty in uni.Faculties)
            {
                foreach (IDepartment department in faculty.Department)
                {
                    if (department.DepartmentHead == null)
                    {
                        departmentsWithoutHead.Add(department);
                    }
                }
            }
        }
    }
}
