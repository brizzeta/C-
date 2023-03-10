using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace _09._03.Translator
{
    internal class Eng_Russ         //англо-русский
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
                var name = el.Attribute("name");
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
        }
    }
    internal class Russ_Eng         //русско-английский
    {
        XDocument xml_r { get; set; }
        public Russ_Eng()
        {
            xml_r = XDocument.Load("../../Russ_Eng.xml");
        }
    }
}
