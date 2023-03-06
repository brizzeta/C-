using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;

namespace XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> purchase = new LinkedList<string>();
            string ch = null;

            while (ch != "11")
            {
                Console.WriteLine($"SHOP\n\n1. Apple — 3.2$\n2. Orange - 3.5$\n3. Cherry - 4.0$\n4. Nuts - 7.0$\n5. Lemon - 3.0$\n6. Potato - 6.7$\n7. Tomato - 7.0$\n8. Cucumber - 7.1$\n9. Cabbage - 5.5$\n10. Avocado - 8.0$\n11. Exit");
                Console.WriteLine("\nEnter variant: ");
                ch = Console.ReadLine();

                switch (ch)
                {
                    case "1":
                        purchase.AddLast("Apple - 3.2$");
                        break;
                    case "2":
                        purchase.AddLast("Orange - 3.5$");
                        break;
                    case "3":
                        purchase.AddLast("Cherry - 4.0$");
                        break;
                    case "4":
                        purchase.AddLast("Nuts - 7.0$");
                        break;
                    case "5":
                        purchase.AddLast("Lemon - 3.0$");
                        break;
                    case "6":
                        purchase.AddLast("Potato - 6.7$");
                        break;
                    case "7":
                        purchase.AddLast("Tomato - 7.0$");
                        break;
                    case "8":
                        purchase.AddLast("Cucumber - 7.1$");
                        break;
                    case "9":
                        purchase.AddLast("Cabbage - 5.5$");
                        break;
                    case "10":
                        purchase.AddLast("Avocado - 8.0$");
                        break;
                    case "11":
                        break;
                }
                Console.WriteLine();
            }            

            XmlTextWriter xmlwriter = new XmlTextWriter("../../Purchase.xml", Encoding.UTF8);
            xmlwriter.WriteStartDocument();
            xmlwriter.Formatting = Formatting.Indented;
            xmlwriter.IndentChar = '\t';
            xmlwriter.Indentation = 1;

            xmlwriter.WriteStartElement("purchase");
            foreach(string str in purchase)
            {
                xmlwriter.WriteStartElement("ware");
                xmlwriter.WriteString(str);
                xmlwriter.WriteEndElement();
            }
            xmlwriter.WriteEndElement();
            Console.WriteLine("Data was saved in XML-file.");
            xmlwriter.Close();

            Console.WriteLine("Show purchase? (y\\n)");
            ch = Console.ReadLine();

            if (ch != "y")
                return;


            //чтение документа

            XmlTextReader reader = new XmlTextReader("../../Purchase.xml");
            string ware = null;

            while (reader.Read()) // Считывает следующий узел из потока
            {
                if (reader.NodeType == XmlNodeType.Text)
                    ware += reader.Value + "\n";
            }

            Console.WriteLine("\n" + ware);
            reader.Close();
        }
    }
}
