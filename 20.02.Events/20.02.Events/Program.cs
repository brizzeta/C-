using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._02.Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Credit_Card card = new Credit_Card("Tatiana Nezina Evgenia", "2025.09.01", 2727, 2000, 900);

            int result = 0;
            while(result != 6)
            {
                Console.Write("MENU\n\n1 Add cache\n2 Remove cache\n3 Start using card\n4 Check accumulate\n5 Change PIN\n6 Exit\n\nYour variant: ");
                result = int.Parse(Console.ReadLine());

                if (result == 6) break;
                
                switch(result)
                {
                    case 1:
                        card.ev += new MyDelegate(card.AddCache);
                        card.Event();
                        card.ev -= new MyDelegate(card.AddCache);
                        break;
                    case 2:
                        card.ev += new MyDelegate(card.RemoveCache);
                        card.Event();
                        card.ev -= new MyDelegate(card.RemoveCache);
                        break;
                    case 3:
                        card.ev += new MyDelegate(card.Start);
                        card.Event();
                        card.ev -= new MyDelegate(card.Start);
                        break;
                    case 4:
                        card.ev += new MyDelegate(card.Check);
                        card.Event();
                        card.ev -= new MyDelegate(card.Check);
                        break;
                    case 5:
                        card.ev += new MyDelegate(card.ChangePIN);
                        card.Event();
                        card.ev -= new MyDelegate(card.ChangePIN);
                        break;
                }
                Console.WriteLine("\n" + card.ToString() + "\n");
            }
        }
    }
}
