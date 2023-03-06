using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._02.Collections_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EngRusDictionary obj = new EngRusDictionary();
            obj.AddList("Great Britain", "Великобритания");
            obj.AddList("Ukraine", "Украина");
            obj.AddList("Japan", "Япония");
            obj.AddList("China", "Китай");
            foreach (string i in obj)
            {
                Console.WriteLine(i);
            }
            ITypeTranslate type = new EngTypeTranslate(obj);
            Console.WriteLine(type.Type("Japan"));
            type = new RusTypeTranslate(obj);
            Console.WriteLine(type.Type("Украина"));
        }
    }
}
