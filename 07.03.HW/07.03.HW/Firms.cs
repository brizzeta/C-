using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _07_03_HW
{
    internal class Firms
    {
        string namecompany;
        int date;
        string profile;
        string NS;
        string marketing;
        int countemployees;
        string adress;

        public List<Employee> Employees { get; set; }

        public string NameCompany
        {
            get
            {
                return namecompany;
            }
            set
            {
                namecompany = value;
            }
        }

        public int Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public string Profile
        {
            get
            {
                return profile;
            }
            set
            {
                profile = value;
            }
        }

        public string NameSurname
        {
            get { return NS; }
            set { NS = value; }
        }

        public int Countemployees
        {
            get
            {
                return countemployees;
            }
            set
            {
                countemployees = value;
            }

        }

        public string Adress
        {
            get
            {
                return adress;
            }
            set
            {
                adress = value;
            }
        }

        public string Marketing
        {
            get
            {
                return marketing;
            }
            set
            {
                marketing = value;
            }
        }

        public Firms()
        {
            namecompany= string.Empty;
            date= 0;
            profile= string.Empty;
            NS = string.Empty;
            countemployees= 0;
            adress = string.Empty;
        }

        public Firms(string namecompany, int date, string marketing, string profile, string nS, int countemployees, string adress)
        {
            this.namecompany = namecompany;
            this.date = date;
            this.marketing = marketing;
            this.profile = profile;
            NS = nS;
            this.countemployees = countemployees;
            this.adress = adress;
        }

        public Firms(string namecompany)
        {
            this.namecompany = namecompany;
        }

        public void AddEmployee(Employee obj)
        {
            Employees.Add(obj);
        }

        public void Output()
        {
            Console.WriteLine(namecompany);
            Console.WriteLine(Employees);
        }

        public override string ToString()
        {
            return $"Name company -> {namecompany}\nDate -> {date}\nProfile -> {profile}\nMarketing -> {marketing}\nName surname -> {NS}\nCount employees -> {countemployees}\nAdress -> {adress}";
        }
    }
}
