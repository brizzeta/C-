using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._02.Anonym_method
{
    delegate void MyDelegate2();
    internal class Backpack
    {
        private string color;
        private string mark;
        private string textile;
        private int weight;
        private int volume;
        private string item;
        private int VolumeItem;
        private int TotalWeightOfItems;
        public event MyDelegate2 ev;

        public Backpack()
        {
            color = string.Empty;
            mark = string.Empty;
            textile = string.Empty;
            weight = 0;
            volume = 0;
            item = string.Empty;
            VolumeItem = 0;
            TotalWeightOfItems = 0;
        }
        public Backpack(string color, string mark, string textile, int weight, int volume, string item, int VolumeItem, int TotalWeightOfItems)
        {
            this.color = color;
            this.mark = mark;
            this.textile = textile;
            this.weight = weight;
            this.volume = volume;
            this.item = item;
            this.VolumeItem = VolumeItem;
            this.TotalWeightOfItems = TotalWeightOfItems;
        }

        public void Input()
        {
            Console.WriteLine("Enter color");
            color = Console.ReadLine();
            Console.WriteLine("Enter mark backpack");
            mark = Console.ReadLine();
            Console.WriteLine("Enter textile backpack");
            textile = Console.ReadLine();
            Console.WriteLine("Enter weight backpack");
            weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter volume backpack");
            volume = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter item");
            item = Console.ReadLine();
            Console.WriteLine("Enter weight item");
            VolumeItem = int.Parse(Console.ReadLine());
            TotalWeightOfItems += VolumeItem;
            if (TotalWeightOfItems > volume)
            {
                throw new Exception("No place");
            }
        }

        public override string ToString()
        {
            return $"Color: {color}\nMark: {mark}\nTextile: {textile}\nWeight backpack: {weight}\nVolume backpack: {volume}\nAll item in the backpack: {item}\nVolume item: {TotalWeightOfItems}\n";
        }

        public void Event()
        {
            ev?.Invoke();
        }

        public void AddItem()
        {
            Console.WriteLine("Enter name item");
            item += " " + Console.ReadLine();
            Console.WriteLine("Enter weight item");
            VolumeItem = int.Parse(Console.ReadLine());
            if (TotalWeightOfItems + VolumeItem > volume)
            {
                throw new Exception("No place");
            }
            TotalWeightOfItems += VolumeItem;
        }
    }
}
