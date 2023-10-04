using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Tictactoe
{
    internal class Presenter
    {
        private readonly IModel model;
        private readonly IView view;

        public Presenter(IModel model, IView view)
        {
            this.model = model;
            this.view = view;
            view.TicTacToeEventOneToOne += OneToOne;
            view.TicTacToeEventEasyBot += EasyBot;
            view.TicTacToeEventComplexBot += ComplexBot;
        }

        private void OneToOne(int index)
        {
            if (model.CurrentMove == 'X')
            {
                Move(index);
            }
            else if (model.CurrentMove == 'O')
            {
                model.Board[index] = "O";
                view.UpdateBoard(model.Board);
                if (model.Check_Win(model.Board) == true)
                {
                    view.ShowMessage($"{model.CurrentMove} win!");
                    view.EnableButtons(false);
                }
                else if (model.Check_Draw())
                {
                    view.ShowMessage("Game draw!");
                    view.EnableButtons(false);
                }
                model.CurrentMove = 'X';
            }
        }

        private void EasyBot(int index)
        {
            if (Move(index) == false)
            {
                List<int> FreePlaces = new List<int>();
                for (int i = 0; i < model.Board.Length; i++)
                {
                    if (int.TryParse(model.Board[i], out int number) == true)
                    {
                        FreePlaces.Add(i);
                    }
                }
                int randStep = new Random().Next(FreePlaces.Count);
                model.Board[FreePlaces[randStep]] = "O";
                view.UpdateBoard(model.Board);
                if (model.Check_Win(model.Board))
                {
                    view.ShowMessage($"{model.CurrentMove} win!");
                    view.EnableButtons(false);
                    model.Retry_Board();
                    model.Restart_Current_Player();
                }
                else if (model.Check_Draw())
                {
                    view.ShowMessage("Game draw!");
                    view.EnableButtons(false);
                    model.Retry_Board();
                    model.Restart_Current_Player();
                }
            }
        }


        private void ComplexBot(int index2)
        {
            if (Move(index2) == false)
            {
                List<int> FreePlaces = new List<int>();
                for (int i = 0; i < model.Board.Length; i++)
                {
                    if (int.TryParse(model.Board[i], out int number) == true)
                    {
                        FreePlaces.Add(i);
                    }
                }
                int[] PriorityPlaces = new int[9] { 4, 0, 2, 6, 8, 1, 3, 5, 7 };
                int index = 0;
                for (int i = 0; i < model.Board.Length; i++)
                {
                    string[] temp = new string[model.Board.Length];
                    for (int j = 0; j < temp.Length; j++)
                    {
                        temp[j] = model.Board[j];
                    }
                    if (temp[FreePlaces[index]] != "X" && temp[FreePlaces[index]] != "O")
                    {
                        temp[FreePlaces[index]] = "O";
                    }
                    if (model.Check_Win(temp) == true)
                    {
                        model.Board[FreePlaces[index]] = "O";
                        view.UpdateBoard(model.Board);
                        view.ShowMessage($"{model.CurrentMove} win!");
                        model.Retry_Board();
                        model.Restart_Current_Player();
                        view.EnableButtons(false);
                        return;
                    }
                    else
                    {
                        if (index != FreePlaces.Count - 1)
                        {
                            index++;
                        }
                    }
                }
                index = 0;
                for (int i = 0; i < model.Board.Length; i++)
                {
                    string[] temp = new string[model.Board.Length];
                    for (int j = 0; j < temp.Length; j++)
                    {
                        temp[j] = model.Board[j];
                    }
                    if (temp[FreePlaces[index]] != "X" && temp[FreePlaces[index]] != "O")
                    {
                        temp[FreePlaces[index]] = "X";
                    }
                    if (model.Check_Win(temp) == true)
                    {
                        model.Board[FreePlaces[index]] = "O";
                        view.UpdateBoard(model.Board);
                        return;
                    }
                    else
                    {
                        if (index != FreePlaces.Count - 1)
                        {
                            index++;
                        }
                    }
                }
                foreach (int i in PriorityPlaces)
                {
                    foreach (int j in FreePlaces)
                    {
                        if (i == j)
                        {
                            model.Board[j] = "O";
                            view.UpdateBoard(model.Board);
                            if (model.Check_Win(model.Board) == true)
                            {
                                model.Board[i] = "O";
                                view.UpdateBoard(model.Board);
                                view.ShowMessage($"{model.CurrentMove} win!");
                                model.Retry_Board();
                                model.Restart_Current_Player();
                                view.EnableButtons(false);
                                return;
                            }
                            else if (model.Check_Draw())
                            {
                                view.ShowMessage("Game draw!");
                                view.EnableButtons(false);
                                model.Retry_Board();
                                model.Restart_Current_Player();
                                return;
                            }
                            return;
                        }
                    }
                }
            }
        }
        private bool Move(int index)
        {
            model.Board[index] = "X";
            view.UpdateBoard(model.Board);
            if (model.Check_Win(model.Board) == true)
            {
                model.CurrentMove = 'X';
                view.ShowMessage($"{model.CurrentMove} win!");
                view.EnableButtons(false);
                model.Restart_Current_Player();
                model.Retry_Board();
                return true;
            }
            else if (model.Check_Draw() == true)
            {
                view.ShowMessage("Game draw!");
                view.EnableButtons(false);
                model.Restart_Current_Player();
                model.Retry_Board();
                model.CurrentMove = 'X';
                return true;
            }
            model.CurrentMove = 'O';
            return false;

        }
    }
}
