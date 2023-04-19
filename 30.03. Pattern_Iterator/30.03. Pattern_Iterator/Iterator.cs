using System;

namespace _30._03.Pattern_Iterator
{
    internal class ConcreteIterator : Iterator
    {
        ConcreteCollection collection;
        string iterationState;
        public ConcreteIterator(ConcreteCollection collection)
        {
            this.collection = collection;
            iterationState = collection.Potemkinski_Stairs;
        }
        public void getNext()
        {
            switch(iterationState)
            {
                case "Potemkinski stairs":
                    iterationState = collection.Opera_theater;
                    break;
                case "Opera theater":
                    iterationState = collection.Deribasivska; 
                    break;
                default: 
                    if(!hasMore())
                    {
                        Console.WriteLine("That's finish!");
                    }
                    break;
            }
        }
        public bool hasMore()
        {
            if(iterationState == "Deribasivska")
                return false;
            return true;
        }
    }
    internal class ConcreteCollection : IterableCollection
    {
        public string Potemkinski_Stairs { get; }
        public string Opera_theater { get; }
        public string Deribasivska { get; }
        public ConcreteCollection() 
        {
            Potemkinski_Stairs = "Potemkinski stairs";
            Opera_theater = "Opera theater";            
            Deribasivska = "Deribasivska";
        }
        public Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
