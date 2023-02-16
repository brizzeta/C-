using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _13._02._2023.Inheritance {
    internal class Passport {
        internal string Full_Name { get; set; }
        internal string Country { get; set; }
        internal string Male { get; set; }
        internal string DateOfBirth { get; set; }
        internal Passport() : this(null, null, null, null) { }
        internal Passport(string full, string coun, string male, string date) {
            Full_Name = full;
            Country = coun;
            Male = male;
            DateOfBirth = date;
        }
        internal virtual void Print() => Console.WriteLine($"Full Name: {Full_Name}\nCountry: {Country}\n" +
                $"Male: {Male}]\nBirth: {DateOfBirth}\n");
        public override string ToString() => $"Full Name: {Full_Name}\nCountry: {Country}\n" +
                $"Male: {Male}]\nBirth: {DateOfBirth}\n";
    }
    internal class ForeignPassport : Passport {
        internal string Visas { get; set; }
        internal int PassNum { get; set; }
        internal ForeignPassport(string full, string coun, string male, string date, string visas, int num)
            : base(full, coun, male, date) {
            Visas = visas;
            PassNum = num;
        }
        internal override void Print() {
            base.Print();
            Console.WriteLine($"Visas: {Visas}\nPassport number: {PassNum}");
        }
        public override string ToString() => base.ToString() + $"Visas: {Visas}\nPassport number: {PassNum}";
    }
}
