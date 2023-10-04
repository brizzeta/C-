using System.CodeDom.Compiler;
using System.Net.Sockets;
using System.Reflection;
using System.Text;

namespace Tictactoe
{
    public partial class Form1 : Form, IView
    {
        public List<Button> Button;
        public int index;

        public event Action<int> TicTacToeEventOneToOne;
        public event Action<int> TicTacToeEventEasyBot;
        public event Action<int> TicTacToeEventComplexBot;
        public Form1()
        {
            InitializeComponent();
            Button = new List<Button>() { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            index = 0;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void EnableButtons(bool enable)
        {
            if (enable == false)
            {
                for (int i = 0; i < Button.Count; i++)
                {
                    Button[i].Enabled = false;
                }
            }
        }

        public void UpdateBoard(string[] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] == "X")
                {
                    Button[i].BackgroundImage = Image.FromFile("Cross.png");
                    Button[i].Enabled = false;
                }
                else if (board[i] == "O")
                {
                    Button[i].BackgroundImage = Image.FromFile("Zero.png");
                    Button[i].Enabled = false;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            index = Button.IndexOf(clicked);
            if (radioButton3.Checked)
            {
                TicTacToeEventOneToOne?.Invoke(index);
            }
            if (radioButton4.Checked)
            {
                if (radioButton1.Checked)
                {
                    TicTacToeEventEasyBot?.Invoke(index);
                }
                if (radioButton2.Checked)
                {
                    TicTacToeEventComplexBot?.Invoke(index);
                }
            }
        }

        private void Button_New_Game_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Button.Count; i++)
            {
                Button[i].Enabled = true;
                Button[i].BackgroundImage = null;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                groupBox1.Enabled = false;
            }
            if (radioButton4.Checked)
            {
                groupBox1.Enabled = true;
            }
        }
    }
}