using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _31._03.Pattern_Memento
{
    internal class Originator
    {
        string text;
        int coursor_pos;
        int screen_scrolling;
        public Memento save()
        {
            return new Memento(text, coursor_pos, screen_scrolling);
        }
        public void restore(Memento memento)
        {
            text = memento.text;
            coursor_pos = memento.coursor_pos;
            screen_scrolling = memento.screen_scrolling;
        }
        public void redo()
        {
            Console.WriteLine("Enter new text:");
            text = Console.ReadLine();
            Console.WriteLine("Enter new coursor position:");
            coursor_pos = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new screen scrolling:");
            screen_scrolling = int.Parse(Console.ReadLine());
        }
    }
    internal class Memento
    {
        public string text { get; }
        public int coursor_pos { get; }
        public int screen_scrolling { get; }
        public Memento(string text, int coursor_pos, int screen_scrolling)
        {
            this.text = text;
            this.coursor_pos = coursor_pos;
            this.screen_scrolling = screen_scrolling;
        }
    }
    internal class Caretaker
    {
        Originator originator;
        List<Memento> history;
        public void undo()
        {
            Memento m = history.Last();
            history.RemoveAt(history.Count);
            originator.restore(m);
        }
        public void save()
        {
            Memento m = originator.save();
            history.Add(m);
            if(history.Count > 255) 
            {
                history.RemoveAt(0);
            }
        }
    }
}
