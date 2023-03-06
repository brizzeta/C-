using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._02.Collections_Laba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Enter text");
            text = Console.ReadLine();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string[] text2 = text.Split(' ');
            foreach (string s in text2)
            {
                if (dict.ContainsKey(s))
                {
                    dict[s]++;
                }
                else
                {
                    dict.Add(s, 1);
                }
            }
            foreach (KeyValuePair<string, int> pair in dict)
                Console.WriteLine($"{pair.Key} {pair.Value}");
        }
    }
}
