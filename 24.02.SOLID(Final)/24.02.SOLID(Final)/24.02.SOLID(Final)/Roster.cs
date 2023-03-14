using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_02_SOLID_Final
{
    internal class Roster
    {
        List<Student> students;
        List<Teacher> teacher;
        University uni;

        public Roster(University uni)
        {
            this.uni = uni;
            students = new List<Student>();
            teacher = new List<Teacher>();
            foreach (IFaculty faculty in uni.Faculties)
            {
                students.AddRange(faculty.students);
                foreach (IDepartment dep in faculty.departments)
                {
                    teacher.AddRange(dep.Teachers);
                    teacher.Add(dep.Head);
                }
            }
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public List<Student> GetStudentsWithoutParents()
        {
            return students.Where(s => s.Parents == null).ToList();
        }
    }
}
