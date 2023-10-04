using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Tictactoe
{
    internal class Model : IModel
    {
        public char CurrentMove { get; set; }
        public string[] Board { get; set; }

        public Model()
        {
            Board = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            CurrentMove = 'X';
        }

        public void Retry_Board()
        {
            for (int i = 0; i < Board.Length; i++)
            {
                Board[i] = Convert.ToString(i);
            }
        }

        public void Restart_Current_Player()
        {
            CurrentMove = 'X';
        }

        public bool Check_Draw()
        {
            foreach (string i in Board)
            {
                if (i != "X" && i != "O")
                    return false;
            }
            return true;
        }

        public bool Check_Win(string[] Board)
        {
            int[,] WinningCombinations = new int[8, 3] { { 0, 1, 2 }, 
                                                         { 3, 4, 5 }, 
                                                         { 6, 7, 8 }, 
                                                         { 0, 3, 6 }, 
                                                         { 1, 4, 7 }, 
                                                         { 2, 5, 8 }, 
                                                         { 0, 4, 8 }, 
                                                         { 2, 4, 6 } };
            for (int i = 0; i < WinningCombinations.GetLength(0); i++)
            {
                if (Board[WinningCombinations[i, 0]] == Board[WinningCombinations[i, 1]] && Board[WinningCombinations[i, 1]] == Board[WinningCombinations[i, 2]])
                {
                    return true;
                }
            }
            return false;
            
        }
    }
}
