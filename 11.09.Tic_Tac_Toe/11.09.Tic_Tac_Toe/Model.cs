using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._09.Tic_Tac_Toe
{
    internal class Model : IModel
    {
        public List<int> list { get; set; }
        public char currentPlayer { get; set; }

        public Model()
        {
            list = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }
        public bool CheckWin()
        {
            int[,] win = new int[8,3] { 
                { 0, 1, 2 }, 
                { 3, 4, 5 }, 
                { 6, 7, 8 }, 
                { 0, 3, 6 }, 
                { 1, 4, 7 }, 
                { 2, 5, 8 }, 
                { 0, 4, 8 }, 
                { 2, 4, 6 } };
            for (var i = 0; i < win.GetLength(0); i++)
            {
                if (list[win[i,0]] == list[win[i, 1]] && list[win[i, 1]] == list[win[i, 2]])
                    return true;
            }
            return false;
        }
    }
}
