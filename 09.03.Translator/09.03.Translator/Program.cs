using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._03.Translator
{    
    internal class Program
    {
        static string Menu()
        {
            Console.WriteLine("МЕНЮ\n");
            Console.WriteLine("1) Добавить слово или перевод в словарь.");
            Console.WriteLine("2) Изменить слово или перевод.");
            Console.WriteLine("3) Удалить слово или перевод.");
            Console.WriteLine("4) Перевести слово.");
            Console.WriteLine("5) Завершить.");
            Console.Write("\nВыбор: ");
            string answ = Console.ReadLine();

            if (answ == "1" || answ == "2" || answ == "3" || answ == "4" || answ == "5")
                return answ;
            else 
                throw new Exception("Неверный ответ.");                        
        }

        static void Main(string[] args)
        {
            string answ2;
            do
            {
                Console.WriteLine("МЕНЮ\n");
                Console.Write("Работать с русско-английским или англо-русским словарем?(1/2): ");
                string answ = Console.ReadLine();

                Console.Clear();
                Translator t;

                if (answ == "1")
                {
                    t = new Russ_Eng();
                }
                else
                {
                    t = new Eng_Russ();
                }

                answ2 = Menu();
                Console.Clear();

                switch (answ2)
                {
                    case "1":
                        t.Add();
                        break;
                    case "2":
                        t.Change();
                        break;
                    case "3":
                        t.Delete();
                        break;
                    case "4":
                        t.Translate();
                        break;
                    case "5":
                        break;
                }
                Console.Clear();
            } while (answ2 != "5");
        }
    }
}
