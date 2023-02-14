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
    class Mass : IOutput, IMath, ISort, ICalc, IOutput2, ICalc2
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
        public int Less(int valueToCompare)        //кол-во значений меньше заданного
        {
            int count = 0;
            foreach(int el in arr)
            {
                if(el < valueToCompare) count++;
            }
            return count;
        }
        public int Greater(int valueToCompare)        //кол-во значений больше заданного
        {
            int count = 0;
            foreach (int el in arr)
            {
                if (el > valueToCompare) count++;
            }
            return count;
        }
        public void ShowEven()              //показать четные элементы
        {
            foreach (int el in arr)
            {
                if (el % 2 == 0) Console.Write(el + " "); 
            }
        }
        public void ShowOdd()               //показать нечетные элементы
        {
            foreach (int el in arr)
            {
                if (el % 2 == 1) Console.Write(el + " ");
            }
        }
        public int CountDistinct()          //кол-во уникальных элементов
        {
            int count = 0;
            foreach (var i in arr.GroupBy(i => i).Where(g => g.Count() == 1).Select(g => g.Key))
                count++;
            return count;
        }
        public int EqualToValue(int valueToCompare)       //кол-во элементов равных к заданному
        {
            int count = 0;
            foreach (int el in arr)
            {
                if (el == valueToCompare) count++;
            }
            return count;
        }
    }
}
