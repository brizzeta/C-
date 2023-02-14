using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_name
{
    interface IOutput    //вывод
    {
        void Show();
        void Show(string info);
    }
    interface IMath     //мат. действия
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }
    interface ISort     //сортировка
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);

    }
}
