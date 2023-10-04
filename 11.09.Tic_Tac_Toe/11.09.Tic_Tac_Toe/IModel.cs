using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._09.Tic_Tac_Toe
{
    internal interface IModel
    {
        List<int> list { get; set; }
        char currentPlayer { get; set; }
        bool CheckWin();
    }
}
