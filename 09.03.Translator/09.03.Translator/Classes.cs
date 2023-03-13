using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace _09._03.Translator
{
    internal class Eng_Russ : Translator       //англо-русский
    {
        XDocument xml_e { get; set; }
        XElement root { get; set; }
        public Eng_Russ()
        {
            xml_e = XDocument.Load("../../Eng_Russ.xml");
            root = xml_e.Element("Eng_Russ");
        }

        public void Add()   // добавляем новый перевод
        {
            Console.Write("Напишите английское слово: ");
            string eng_word = Console.ReadLine();

            Console.Write("Напишите слова для перевода: ");
            string[] words_russ = Console.ReadLine().Split(' ');

            var eng = root.Elements("word")?.FirstOrDefault(p => p.Attribute("eng").Value == eng_word);

            if (eng == null)        //если перевода не было
            {
                root.Add(new XElement("word",
                            new XAttribute("eng", eng_word)));                                
            }

            eng = root.Elements("word")?.FirstOrDefault(p => p.Attribute("eng").Value == eng_word);

            foreach (string word in words_russ)   //добавляем перевод
            {
                eng.Add(new XElement("russ", word));
            }

            xml_e.Save("../../Eng_Russ.xml");

            Console.WriteLine("\nНажмите клавишу для продолжения....");
            Console.ReadKey();
        }

        public void Change()
        {
            Console.Write("Напишите слово для изменения: ");
            string word = Console.ReadLine();

            Console.Write("Напишите новое слово: ");
            string new_word = Console.ReadLine();

            //если нужно переписать англ слово
            var el = root.Elements("word")?.FirstOrDefault(p => p.Attribute("eng").Value == word);

            if (el != null)      //если нужно переписать англ слово
            {
                var name = el.Attribute("eng");
                name.Value = new_word;                
            }
            else
            {
                el = root.Elements("word")?.FirstOrDefault(p => p.Element("russ").Value == word);

                if(el == null) throw new Exception("Не найдено такого слова.");

                var name = el.Element("russ");
                name.Value = new_word;
            }

            xml_e.Save("../../Eng_Russ.xml");

            Console.WriteLine("\nНажмите клавишу для продолжения....");
            Console.ReadKey();
        }

        public void Delete()
        {
            Console.Write("Удалить английское слово или его перевод (1/2): ");
            int res = int.Parse(Console.ReadLine());            

            if (res == 1)      //если нужно удалить англ слово
            {
                Console.Write("Напишите слово для удаления: ");
                string word = Console.ReadLine();

                var el = root.Elements("word")?.FirstOrDefault(p => p.Attribute("eng").Value == word);
                if (el == null) throw new Exception("Не найдено такого слова.");
                el.Remove();
            }
            else              //если нужно удалить русское слово
            {
                Console.Write("Напишите английское слово: ");
                string eng_word = Console.ReadLine();

                Console.Write("Напишите его перевод для удаления: ");
                string rus_word = Console.ReadLine();

                //кол-во переводов
                var eng_el_c = root.Elements("word")?.FirstOrDefault(p => p.Attribute("eng").Value == eng_word)?.Elements("russ").Count();

                if(eng_el_c > 1)
                {
                    var rus_el = root.Elements("word")?.FirstOrDefault(p => p.Attribute("eng").Value == eng_word);
                    var russ_el = rus_el.Elements("russ").FirstOrDefault(p => p.Value == rus_word);
                    russ_el.Remove();
                }
                else throw new Exception("Не найдено такого слова или переводов меньше 2.");
            }
            xml_e.Save("../../Eng_Russ.xml");

            Console.WriteLine("\nНажмите клавишу для продолжения....");
            Console.ReadKey();
        }

        public void Translate()
        {
            Console.Write("Напишите английское слово: ");
            string eng_word = Console.ReadLine();

            var rus_word = root.Elements("word")?.FirstOrDefault(p => p.Attribute("eng").Value == eng_word)?.Elements("russ");
            foreach(var el in rus_word)
            {
                Console.WriteLine(el.Value);
            }

            Console.WriteLine("\nНажмите клавишу для продолжения....");
            Console.ReadKey();
        }
    }
    internal class Russ_Eng : Translator         //русско-английский
    {
        XDocument xml_e { get; set; }
        XElement root { get; set; }
        public Russ_Eng()
        {
            xml_e = XDocument.Load("../../Russ_Eng.xml");
            root = xml_e.Element("Russ_Eng");
        }

        public void Add()   // добавляем новый перевод
        {
            Console.Write("Напишите русское слово: ");
            string rus_word = Console.ReadLine();

            Console.Write("Напишите слова для перевода: ");
            string[] words_eng = Console.ReadLine().Split(' ');

            var russ = root.Elements("word")?.FirstOrDefault(p => p.Attribute("russ").Value == rus_word);

            if (russ == null)        //если перевода не было
            {
                root.Add(new XElement("word",
                            new XAttribute("russ", rus_word)));
            }

            russ = root.Elements("word")?.FirstOrDefault(p => p.Attribute("russ").Value == rus_word);

            foreach (string word in words_eng)   //добавляем перевод
            {
                russ.Add(new XElement("eng", word));
            }

            xml_e.Save("../../Russ_Eng.xml");

            Console.WriteLine("\nНажмите клавишу для продолжения....");
            Console.ReadKey();
        }

        public void Change()
        {
            Console.Write("Напишите слово для изменения: ");
            string word = Console.ReadLine();

            Console.Write("Напишите новое слово: ");
            string new_word = Console.ReadLine();

            //если нужно переписать русское слово
            var el = root.Elements("word")?.FirstOrDefault(p => p.Attribute("russ").Value == word);

            if (el != null)      //если нужно переписать русское слово
            {
                var name = el.Attribute("eng");
                name.Value = new_word;
            }
            else
            {
                el = root.Elements("word")?.FirstOrDefault(p => p.Element("eng").Value == word);

                if (el == null) throw new Exception("Не найдено такого слова.");

                var name = el.Element("eng");
                name.Value = new_word;
            }

            xml_e.Save("../../Russ_Eng.xml");

            Console.WriteLine("\nНажмите клавишу для продолжения....");
            Console.ReadKey();
        }

        public void Delete()
        {
            Console.Write("Удалить русское слово или его перевод (1/2): ");
            int res = int.Parse(Console.ReadLine());

            if (res == 1)      //если нужно удалить русское слово
            {
                Console.Write("Напишите слово для удаления: ");
                string word = Console.ReadLine();

                var el = root.Elements("word")?.FirstOrDefault(p => p.Attribute("russ").Value == word);
                if (el == null) throw new Exception("Не найдено такого слова.");
                el.Remove();
            }
            else              //если нужно удалить англ слово
            {
                Console.Write("Напишите русское слово: ");
                string rus_word = Console.ReadLine();

                Console.Write("Напишите его перевод для удаления: ");
                string eng_word = Console.ReadLine();

                //кол-во переводов
                var rus_el_c = root.Elements("word")?.FirstOrDefault(p => p.Attribute("russ").Value == rus_word)?.Elements("eng").Count();

                if (rus_el_c > 1)
                {
                    var en_el = root.Elements("word")?.FirstOrDefault(p => p.Attribute("russ").Value == rus_word);
                    var eng_el = en_el.Elements("eng").FirstOrDefault(p => p.Value == eng_word);
                    eng_el.Remove();
                }
                else throw new Exception("Не найдено такого слова или переводов меньше 2.");
            }

            xml_e.Save("../../Russ_Eng.xml");

            Console.WriteLine("\nНажмите клавишу для продолжения....");
            Console.ReadKey();
        }

        public void Translate()
        {
            Console.Write("Напишите русское слово: ");
            string rus_word = Console.ReadLine();

            var eng_word = root.Elements("word")?.FirstOrDefault(p => p.Attribute("russ").Value == rus_word)?.Elements("eng");
            foreach (var el in eng_word)
            {
                Console.WriteLine(el.Value);
            }

            Console.WriteLine("\nНажмите клавишу для продолжения....");
            Console.ReadKey();
        }
    }
}
