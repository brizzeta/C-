using Interfaces_name;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Mass_name
{
    class Mass : IOutput, IMath, ISort
    {
        public int[] arr;
        public Mass(int length)       //конструктор с парам
        {
            arr = new int[length];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0, 6);
            }
        }
        public int this[int ind]      //индексатор
        {
            get
            {
                if (ind < arr.Length && ind >= 0) return arr[ind];
                else throw new IndexOutOfRangeException();
            }
            set
            {
                if (ind < arr.Length && ind >= 0) arr[ind] = value;
                else throw new IndexOutOfRangeException();
            }
        }
        public void Show()             //вывод массива
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        public void Show(string info)         //вывод с информацией
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine("\nInfo: " + info);
        }
        public int Max() => arr.Max();    //макс эл в массиве
        public int Min() => arr.Min();    //мин эл в массиве
        public float Avg() => (float)arr.Average();     //среднее арифметическое
        public bool Search(int valueToSearch) => arr.Any(x => x > valueToSearch);   //проверка эл в массиве
        public void SortAsc()                //сортировка по убыванию
        {
            Array.Sort(arr);
        }
        public void SortDesc()              //сортировка по возрастанию
        {
            Array.Sort(arr);
            Array.Reverse(arr);
        }
        public void SortByParam(bool isAsc)        //сортировка в зависимости от значения
        {
            if(isAsc)
                SortAsc();
            else SortDesc();
        }
    }
}
