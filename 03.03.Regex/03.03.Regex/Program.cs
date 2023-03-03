using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03._03.Regex_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //проверка почты

            //Regex reg = new Regex(@"^(\w+\d+)@gmail\.com$");

            //Console.Write("Enter e-mail: ");
            //string mail = Console.ReadLine();

            //if (reg.IsMatch(mail)) { Console.WriteLine("Correct!"); }
            //else { Console.WriteLine("NOT correct."); }



            //проверка номера телефона

            //Regex reg2 = new Regex(@"^\+?\d{5}-\d{3}-\d{2}-\d{2}$");

            //Console.Write("Enter phone number: ");
            //string num = Console.ReadLine();

            //if (reg2.IsMatch(num)) { Console.WriteLine("Correct!"); }
            //else { Console.WriteLine("NOT correct."); }



            //проверка IP

            //Regex reg3 = new Regex(@"^\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}$");

            //Console.Write("Enter IP: ");
            //string ip = Console.ReadLine();

            //if (reg3.IsMatch(ip)) { Console.WriteLine("Correct!"); }
            //else { Console.WriteLine("NOT correct."); }



            //подсчет гласных

            //Regex reg4 = new Regex(@"[bcdfghjklmnpqrstvwxyz]", RegexOptions.IgnoreCase);

            //Console.Write("Enter text: ");
            //string str = Console.ReadLine();
            //int val = 0;

            //foreach (Match match in reg4.Matches(str))
            //{
            //    val++;
            //}

            //Console.WriteLine("Count of vowels: " + val);



            //проверка URL

            //Regex reg5 = new Regex(@"^www\.\w+\.(com|ua)$");

            //Console.Write("Enter URL: ");
            //string url = Console.ReadLine();

            //if (reg5.IsMatch(url)) { Console.WriteLine("Correct!"); }
            //else { Console.WriteLine("NOT correct."); }



            //проверка на буквенно-цифровое выражение

            //Regex reg6 = new Regex(@"^\w+$");

            //Console.Write("Enter text: ");
            //string str2 = Console.ReadLine();

            //if (reg6.IsMatch(str2)) { Console.WriteLine("Correct!"); }
            //else { Console.WriteLine("NOT correct."); }



            //проверка на время

            //Regex reg7 = new Regex(@"^(([01][0-9])|([2][0-3]))(:|\.)[0-5][0-9]((:|\.)[0-5][0-9])?$");

            //Console.Write("Enter time: ");
            //string time = Console.ReadLine();

            //if (reg7.IsMatch(time)) { Console.WriteLine("Correct!"); }
            //else { Console.WriteLine("NOT correct."); }



            //почтовый индекс США

            //Regex reg8 = new Regex(@"^\d{5}-\d{5}$");

            //Console.Write("Enter post index USA: ");
            //string ind = Console.ReadLine();

            //if (reg8.IsMatch(ind)) { Console.WriteLine("Correct!"); }
            //else { Console.WriteLine("NOT correct."); }




            //----------------------------- ДЗ --------------------------




            //1 задание

            //string str = "ahb acb aeb aeeb adcb axeb";
            //Regex reg = new Regex(@"a\wb");

            //int val = 0;

            //foreach (Match match in reg.Matches(str))
            //{
            //    val++;
            //}

            //Console.WriteLine("Count of vowels: " + val);



            //2

            //string str = "ahb acb aeeb adcb axeb";
            //Regex reg = new Regex(@"a\w{2}b");

            //int val = 0;

            //foreach (Match match in reg.Matches(str))
            //{
            //    val++;
            //}

            //Console.WriteLine("Count of vowels: " + val);



            //3

            //string str = "ahb acb aeeb adcb axeb";
            //Regex reg = new Regex(@"a\w{2}b[^dc]");

            //int val = 0;

            //foreach (Match match in reg.Matches(str))
            //{
            //    val++;
            //}

            //Console.WriteLine("Count of vowels: " + val);



            //4

            //string str = "aa aba abba abbba abca abea";
            //Regex reg = new Regex(@"ab+a");

            //int val = 0;

            //foreach (Match match in reg.Matches(str))
            //{
            //    val++;
            //}

            //Console.WriteLine("Count of vowels: " + val);



            //5

            //string str = "aa aba abba abbba abca abea";
            //Regex reg = new Regex(@"ab*a");

            //int val = 0;

            //foreach (Match match in reg.Matches(str))
            //{
            //    val++;
            //}

            //Console.WriteLine("Count of vowels: " + val);



            //6

            //string str = "aa aba abba abbba abca abea";
            //Regex reg = new Regex(@"ab?a");

            //int val = 0;

            //foreach (Match match in reg.Matches(str))
            //{
            //    val++;
            //}

            //Console.WriteLine("Count of vowels: " + val);



            //7

            //string str = "aa aba abba abbba abca abea";
            //Regex reg = new Regex(@"ab{0,}a");

            //int val = 0;

            //foreach (Match match in reg.Matches(str))
            //{
            //    val++;
            //}

            //Console.WriteLine("Count of vowels: " + val);



            //8

            //string str = "aa aba abba abbba abca abea";
            //Regex reg = new Regex(@"(ab)+");

            //int val = 0;

            //foreach (Match match in reg.Matches(str))
            //{
            //    val++;
            //}

            //Console.WriteLine("Count of vowels: " + val);

        }
    }
}
