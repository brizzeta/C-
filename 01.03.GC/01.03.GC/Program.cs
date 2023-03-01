using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._03.GC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                Play a = new Play("Adore", "Vlas Vladimir Ivanovich", "Comedy", 2010);
            }
            for (int i = 0; i < 10; i++)
            {
                Play a = new Play("Adore", "Vlas Vladimir Ivanovich", "Comedy", 2010);
                a.Dispose();
            }
            for (int i = 0; i < 10; i++)
            {
                Shop s = new Shop("Cherry", "Krasnova, 34", "Food");
            }
            for (int i = 0; i < 10; i++)
            {
                Shop s = new Shop("Cherry", "Krasnova, 34", "Food");
                s.Dispose();
            }
        }
    }
}
