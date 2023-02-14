using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_name
{
    interface IOutput        //вывод
    {
        void Show();
        void Show(string info);
    }
    interface IMath         //мат. действия
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }
    interface ISort          //сортировка
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }
    interface ICalc         //кол-во элементов больше и меньшу заданного числа
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }
    interface IOutput2       //вывод четных и нечетных элементов
    {
        void ShowEven();
        void ShowOdd();
    }
    interface ICalc2         //кол-во уникальных элементов и равных заданному числу
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }
}
