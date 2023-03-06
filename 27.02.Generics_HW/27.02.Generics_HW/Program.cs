using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._02.Generics_HW
{
    class MySwap<T>
    {
        public void Swap(ref T value1, ref T value2)
        {
            T temp = value1;
            value1 = value2;
            value2 = temp;
        }
    }
    class MyQueuePriority<T>
    {
        private List<Tuple<T, int>> list;
        public MyQueuePriority()
        {
            list = new List<Tuple<T, int>>();
        }
        public void Clear()
        {
            list.Clear();
        }
        public bool Contains() => list.Count > 0;

        public void Enqueue(T list, int value)
        {
            this.list.Add(Tuple.Create(list, value));
        }
        public T Dequeue()
        {

            int index = 0;
            if (list.Count == 0)
            {
                throw new Exception("Circle queue empty");
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Item2 < list[index].Item2)
                    {
                        index = i;
                    }
                }

                T list2 = list[index].Item1;
                list.RemoveAt(index);
                return list2;
            }
        }
        public int Count() => list.Count();
    }
    class MyQueueCircle<T>
    {
        T[] arr;
        int head;
        int tail;
        int count;

        public MyQueueCircle(int size)
        {
            arr = new T[size];
            head = 0;
            tail = -1;
            count = 0;
        }
        public void Enqueue(T value)
        {
            if (count == arr.Length)
            {
                throw new Exception("Circle queue full");
            }
            else
            {
                tail = (tail + 1) % arr.Length;
                arr[tail] = value;
                count++;
            }
        }
        public T Dequeue()
        {
            if (count == 0)
            {
                throw new Exception("Circle queue empty");
            }
            else
            {
                T value = arr[head];
                head = (head + 1) % arr.Length;
                count--;
                return value;
            }
        }
        public T Peek()
        {
            if (count == 0)
            {
                throw new Exception("Circle queue empty");
            }
            else
                return arr[head];
        }
        public void Clear()
        {
            head = 0;
            tail = -1;
            count = 0;
        }
        public int Count() => count;
        public bool Contains(T value)
        {
            int index = 0;
            for (int i = 0; i < count; i++)
            {
                index = (head + i) % arr.Length;
                if (Equals(arr[index], value))
                    return true;
            }
            return false;
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                yield return arr[i];
            }
        }
    }
    internal class Program
    {
        static void Task1()
        {
            int x = 1, y = 2;
            Console.WriteLine("X -> " + x + " Y -> " + y);
            MySwap<int> obj = new MySwap<int>();
            obj.Swap(ref x, ref y);
            Console.WriteLine("X -> " + x + " Y -> " + y);
        }
        static void Task2()
        {
            MyQueuePriority<string> obj = new MyQueuePriority<string>();
            obj.Enqueue("Obama", 2);
            obj.Enqueue("Baiden", 1);
            Console.WriteLine(obj.Count());
            Console.WriteLine(obj.Contains());
            Console.WriteLine(obj.Dequeue());
            Console.WriteLine(obj.Dequeue());
        }
        static void Task3()
        {
            MyQueueCircle<string> obj = new MyQueueCircle<string>(10);
            obj.Enqueue("Circle");
            obj.Enqueue("Cube");
            Console.WriteLine(obj.Count());
            Console.WriteLine(obj.Contains("Circle"));
            foreach (string i in obj)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine(obj.Dequeue());
            Console.WriteLine(obj.Dequeue());
            Console.WriteLine(obj.Count());
        }
        static void Main(string[] args)
        {
            Task1();
            //Task2();
            //Task3();
        }
    }
}
