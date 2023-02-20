using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._02.Events
{
    delegate void MyDelegate();
    internal class Credit_Card
    {
        List<MyDelegate> list = new List<MyDelegate>();
        public string Full_Name { get; set; }
        public string Term { get; set; }
        public int PIN { get; set; }
        public float Limit { get; set; }
        public float Cache { get; set; }
        public Credit_Card(string full_Name, string term, int pIN, float limit, float cache)
        {
            Full_Name = full_Name;
            Term = term;
            PIN = pIN;
            Limit = limit;
            Cache = cache;
        }
        public override string ToString() => $"Full name: {Full_Name}\nTerm of use: {Term}\nPIN: {PIN}\nCredir limit: {Limit}\nCache: {Cache}";
        public event MyDelegate ev
        {
            add {  list.Add(value); }
            remove { list.Remove(value); }
        }
        public MyDelegate this[int ind]
        {
            get
            {
                if (ind >= 0 && ind < list.Count)
                    return list[ind];
                else throw new IndexOutOfRangeException();
            }
            set
            {
                if (ind >= 0 && ind < list.Count)
                    list[ind] = value;
                else throw new IndexOutOfRangeException();
            }
        }
        public void Event()
        {
            if(list.Count != 0)
            {
                foreach (MyDelegate el in list) el();
            }
        }
        public void AddCache()
        {
            Console.Write("Enter amount of cache to add: ");
            float cache = float.Parse(Console.ReadLine());
            Cache += cache;
        }
        public void RemoveCache()
        {
            Console.Write("Enter amount of cache to remove: ");
            float cache = float.Parse(Console.ReadLine());
            Cache -= cache;
        }
        public void Start()
        {
            Console.WriteLine("Start of using the credit card.");
        }
        public void Check() 
        {
            Console.Write("Enter amount of cache to accumulated: ");
            float cache = float.Parse(Console.ReadLine());

            if (Cache >= cache)
                Console.WriteLine("Amount accumulated.");
            else Console.WriteLine("Amount NOT accumulated.");
        }
        public void ChangePIN()
        {
            Console.Write("Enter new PIN: ");
            int pin = int.Parse(Console.ReadLine());
            PIN = pin;
        }
    }
}
