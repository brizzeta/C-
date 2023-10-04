using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tictactoe
{
    internal interface IView
    {
        event Action<int> TicTacToeEventOneToOne;
        event Action<int> TicTacToeEventEasyBot;
        event Action<int> TicTacToeEventComplexBot;
        void UpdateBoard(string[] board);
        void ShowMessage(string message);
        void EnableButtons(bool enable);
    }
}
