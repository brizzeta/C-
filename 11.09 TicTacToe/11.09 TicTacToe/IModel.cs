using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tictactoe
{
    internal interface IModel
    {
        char CurrentMove { get; set; }
        string[] Board { get; set; }

        void Retry_Board();
        void Restart_Current_Player();

        bool Check_Draw();

        bool Check_Win(string[] board);
    }
}
