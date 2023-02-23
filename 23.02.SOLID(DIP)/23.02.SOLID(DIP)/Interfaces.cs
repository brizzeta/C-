using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._02.SOLID_DIP_
{
    public interface ICurrency
    {
        void SelectCurrency();
    }
    public interface ICheck
    {
        void SelectCheck();
    }
}
