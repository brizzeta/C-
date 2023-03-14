using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_03_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Firms[] obj = new Firms[3] {
                new Firms("Silpo", 1998, "No", "Food", "Vladimir Kostelman", 200, "Ukraine"),
                new Firms("Apple", 1976, "Yes", "IT", "Tim Cook", 2021, "USA"),
                //new Firms("Samsung", 1938, "Technic", "Lee Jae Young", 2000, "Korea"),
                new Firms("ATB", 1993, "No", "Food", "Gennady Butkevich", 1000, "Ukraine")
                //new Firms("Nvidia", 1993, "Video-Card", "Jensen Huang", 2000, "USA")
            };
            foreach (var i in obj) 
            { 
                Console.Write(i);
            }
            var selectedprofile = obj.Where(t => t.Profile == "Food");
            Console.WriteLine("\n---------------------------------------------");
            foreach (var i in selectedprofile)
            {
                Console.Write(i);
            }
            var selectedmarketing = obj.Where(t => t.Marketing == "Yes");
            Console.WriteLine("\n---------------------------------------------");
            foreach (var i in selectedmarketing)
            {
                Console.Write(i);
            }
            var selectedprofilemarketing = obj.Where(t => t.Profile == "IT" || t.Marketing == "Yes");
            Console.WriteLine("\n---------------------------------------------");
            foreach (var i in selectedprofilemarketing)
            {
                Console.WriteLine(i);
            }
            var selectedcountemployee = obj.Where(t => t.Countemployees > 100);
            Console.WriteLine("\n---------------------------------------------");
            foreach (var i in selectedcountemployee)
            {
                Console.WriteLine(i);
            }
            var selectedcountemployee2 = obj.Where(t => t.Countemployees >= 100 && t.Countemployees<= 300);
            Console.WriteLine("\n---------------------------------------------");
            foreach(var i in selectedcountemployee2)
            {
                Console.WriteLine(i);
            }
            var selectedcountry = obj.Where(t => t.Adress == "London");
            Console.WriteLine("\n---------------------------------------------");
            foreach (var i in selectedcountry)
            {
                Console.WriteLine(i);
            }
            DateTime now = new DateTime();
            var selectedyear = obj.Where(t => t.Date == now.Year - 2);
            Console.WriteLine("\n---------------------------------------------");
            foreach (var i in selectedyear)
            {
                Console.WriteLine(i);
            }
            var selectedday = obj.Where(t => t.Date == now.Day - 123);
            Console.WriteLine("\n---------------------------------------------");
            foreach (var i in selectedday)
            {
                Console.WriteLine(i);
            }
            Firms[] company = new Firms[1] { new Firms ("Apple") };
            company[0].AddEmployee(new Employee("Sergey Ivanov", "Programmer", "+380435743534", "sergey@gmail.com", 100000));
            company[0].AddEmployee(new Employee("Jack Vilson", "Designer", "+1435743534", "jack@gmail.com", 90000));
            company[0].AddEmployee(new Employee("Mark Vilson", "System administration", "+25683480957", "mark@gmail.com", 95000));
            var selectemployee = company.Where(t => t.NameCompany == "Apple");
            foreach(var i in selectemployee)
            {
                Console.WriteLine(i.Employees);
            }
            var highPaidEmployees = company[0].Employees.Where(t => t.Pay > 50000);
            foreach (var i in highPaidEmployees)
            {
                Console.WriteLine(i);
            }
            var manager = company[0].Employees.Where(t => t.JobTitle == "Maganer");
            foreach (var i in manager)
            {
                Console.WriteLine(i);
            }
            var name = company[0].Employees.Where(t => t.NameSurname == "Lionel");
        }
    }
}
