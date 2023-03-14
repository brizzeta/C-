using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_03_HW
{
    internal class Employee
    {
        string NS;
        string jobtitle;
        string phone;
        string email;
        int pay;

        public string NameSurname
        {
            get { return NS; }
            set { NS = value; }
        }

        public string JobTitle
        {
            get { return jobtitle; }
            set { jobtitle = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }

        public int Pay
        {
            get { return pay; }
            set
            {
                pay = value;
            }
        }

        public Employee(string nS, string jobtitle, string phone, string email, int pay)
        {
            NS = nS;
            this.jobtitle = jobtitle;
            this.phone = phone;
            this.email = email;
            this.pay = pay;
        }

        public override string ToString()
        {
            return $"Name surname -> {NS}\nJob title -> {jobtitle}\nPhone -> {phone}\nEmail->{email}\nPay -> {pay}\n";
        }
    }
}
