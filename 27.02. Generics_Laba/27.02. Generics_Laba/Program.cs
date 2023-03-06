using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._02.Generics_Laba
{
    class Test<T> where T : IComparable<T>
    {
        public T a { get; set; }
        public Test(T a)
        {
            this.a = a;
        }
        public static bool operator >(Test<T> obj1, Test<T> obj2) => obj1.a.CompareTo(obj2.a) > 0;
        public static bool operator <(Test<T> obj1, Test<T> obj2) => obj1.a.CompareTo(obj2.a) < 0;
        public static Test<T> Max(Test<T> a, Test<T> b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
        public static Test<T> Min(Test<T> a, Test<T> b)
        {
            if (a < b)
            {
                return a;
            }
            return b;
        }

    }
    class MyArraySumm<T>
    {
        T[] arr;
        public MyArraySumm(int size)
        {
            arr = new T[size];
        }
        public T Summ()
        {
            T summ = default(T);
            for (int i = 0; i < arr.Length; i++)
            {
                summ = arr[i] + (dynamic)summ;
            }
            return summ;
        }
        public T this[int r]
        {
            get
            {
                if (r < 0 || r >= arr.GetLength(0))
                {
                    throw new Exception("Index error");
                }
                else
                    return arr[r];
            }
            set
            {
                if (r < 0 || r >= arr.GetLength(0))
                {
                    throw new Exception("Index error");
                }
                else
                    arr[r] = value;
            }
        }
    }
    class MyStack<T>
    {
        T[] arr;
        public MyStack()
        {
            arr = new T[0];
        }
        public MyStack(int size)
        {
            arr = new T[size];
        }
        public void push(T value)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = value;
        }
        public void pop()
        {
            if (arr.Length == 0)
            {
                throw new Exception("Stack empty");
            }
            else
            {
                Array.Resize(ref arr, arr.Length - 1);

            }
        }
        public T peek()
        {
            if (arr.Length == 0)
            {
                throw new Exception("Stack empty");
            }
            else
            {
                return arr[0];
            }
        }
        public int count() => arr.Length;
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                yield return arr[i];
            }
        }
    }
    class MyQueue<T>
    {
        T[] arr;
        public MyQueue()
        {
            arr = new T[0];
        }
        public MyQueue(int size)
        {
            arr = new T[size];
        }
        public void enqueue(T value)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = value;
        }
        public void dequeue()
        {
            if (arr.Length == 0)
            {
                throw new Exception("Queue empty");
            }
            else
            {
                T[] arr2 = new T[arr.Length - 1];
                Array.Copy(arr, 1, arr2, 0, arr.Length - 1);
                arr = arr2;

            }
        }
        public T peek()
        {
            if (arr.Length == 0)
            {
                throw new Exception("Queue empty");
            }
            else
            {
                return arr[0];
            }
        }
        public int count() => arr.Length;
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
        static void Task1_2()
        {
            Test<int> obj = new Test<int>(20);
            Test<int> obj2 = new Test<int>(30);
            Test<int> obj3 = Test<int>.Max(obj, obj2);
            Console.WriteLine(obj3.a);
            obj3 = Test<int>.Min(obj, obj2);
            Console.WriteLine(obj3.a);
        }
        static void Task3()
        {
            MyArraySumm<int> arr = new MyArraySumm<int>(4);
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            Console.WriteLine("Summa -> " + arr.Summ());
        }
        static void Task4()
        {
            MyStack<int> obj = new MyStack<int>();
            obj.push(2);
            obj.push(3);
            foreach (int i in obj)
            {
                Console.WriteLine(i);
            }
            obj.pop();
            Console.WriteLine("   ");
            foreach (int i in obj)
            {
                Console.WriteLine(i);
            }
            obj.push(3);
            obj.push(3);
            obj.push(3);
            obj.push(3);
            foreach (int i in obj)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("   ");
            Console.WriteLine(obj.peek());
            Console.WriteLine(obj.count());
        }
        static void Task5()
        {
            MyQueue<string> obj = new MyQueue<string>();
            obj.enqueue("hello");
            obj.enqueue("world");
            foreach (string i in obj)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            obj.dequeue();
            foreach (string i in obj)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            Console.WriteLine(obj.peek());
            Console.WriteLine(obj.count());
        }
        static void Main(string[] args)
        {
            Task1_2();
            //Task3();
            //Task4();
            //Task5();
        }
    }
}
