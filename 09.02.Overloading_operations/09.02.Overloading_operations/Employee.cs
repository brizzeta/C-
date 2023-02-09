using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_name
{
    class Employee
    {
        string name;
        string dob;
        string num;
        string email;
        string post;
        string respons;
        double salary;
        public Employee()
        {
            name = dob = num = email = post = respons = null;
            salary = 0;
        }
        public Employee(string name, string d, string num, string e, string p, string r, double s)
        {
            this.name = name;
            dob = d;
            this.num = num;
            email = e;
            post = p;
            respons = r;
            salary = s;
        }
        public override string ToString()
        {
            return$"Name: {name}\nDOB: {dob}\nNumber: {num}\nEmail: {email}\nPost: {post}\nResponsibilities: {respons}\nSalary: {salary}\n";
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Dob
        {
            get => dob;
            set => dob = value;
        }
        public string Num
        {
            get => num;
            set => num = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public string Post
        {
            get => post;
            set => post = value;
        }
        public string Respons
        {
            get => respons;
            set => respons = value;
        }
        public double Salary
        {
            get => salary;
            set => salary = value;
        }
        public static Employee operator +(Employee e, double s)
        {
            Employee a = new Employee();
            a = e; a.Salary += s;
            return a;
        }
        public static Employee operator -(Employee e, double s)
        {
            Employee a = new Employee();
            a = e; a.Salary -= s;
            return a;
        }
        public static bool operator ==(Employee e1, Employee e2)
        {
            return e1.salary == e2.salary;
        }
        public static bool operator !=(Employee e1, Employee e2)
        {
            return e1.salary != e2.salary;
        }
        public static bool operator <(Employee e1, Employee e2)
        {
            return e1.salary < e2.salary;
        }
        public static bool operator >(Employee e1, Employee e2)
        {
            return e1.salary > e2.salary;
        }
    }
}
