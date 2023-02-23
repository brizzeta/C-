using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._02.SOLID_SRP_OCP_
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
