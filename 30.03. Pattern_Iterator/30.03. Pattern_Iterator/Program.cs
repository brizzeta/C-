namespace _30._03.Pattern_Iterator
{
    internal interface Iterator
    {
        void getNext();
        bool hasMore();
    }
    internal interface IterableCollection
    {
        Iterator CreateIterator();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
