using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05._04.Winforms1
{
    public partial class Form1 : Form
    {
        public int HeightNew { get; set; }
        public int WidthNew { get; set; }
        public Form1()
        {
            InitializeComponent();
            HeightNew = 700;
            WidthNew = 1000;
            Size = new Size(WidthNew, HeightNew);
        }
        public void Task1()
        {
            string name = "Motorina Nikol Pavlovna";
            string title = "Resume";
            string years = "19 years";
            string job = "Programmer";
            MessageBox.Show(name, title, MessageBoxButtons.OK);
            MessageBox.Show(years, title, MessageBoxButtons.OK);
            MessageBox.Show(job, title, MessageBoxButtons.OK);
            int count = (name.Length + (title.Length * 3) + years.Length + job.Length) / 3;
            MessageBox.Show("Thank you!", $"Symbols: {count}", MessageBoxButtons.OK);
        }
        public void Task2()
        {
            DialogResult game = DialogResult.Yes;
            while(game == DialogResult.Yes)
            {                
                int num = 1000;
                int num2 = 1000;
                MessageBox.Show("Guess the number 1-2000", "Game", MessageBoxButtons.OK);

                while (true)
                {
                    DialogResult res = MessageBox.Show($"It's {num}?", "Game", MessageBoxButtons.YesNo);

                    if (res == DialogResult.Yes)
                    {
                        game = MessageBox.Show("WIN!!! New game?", "Game", MessageBoxButtons.YesNo);
                        break;
                    }
                    else
                    {
                        res = MessageBox.Show($"It's > than {num}?", "Game", MessageBoxButtons.YesNo);

                        if (res == DialogResult.Yes)
                        {
                            num2 /= 2;
                            num += num2;
                        }
                        else
                        {
                            num2 /= 2;
                            num -= num2;
                        }
                    }
                }                
            }
        }
        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            Form frm = (Form)sender;
            frm.Text = String.Format("x = {0}  y = {1}", e.X, e.Y);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Form frm = (Form)sender;
            frm.Text = String.Format("x = {0}  y = {1}", e.X, e.Y);

            if (e.Button == MouseButtons.Left)
            {
                if(e.X < 10 || e.X > Width - 10 || e.Y < 10 || e.Y > Height - 10)
                {
                    MessageBox.Show("Out rectangle.");
                }
                else if(e.X == 10 || e.X == Width - 10)
                {
                    if(e.Y >= 10 && e.Y <= Height - 10)
                        MessageBox.Show("Border of rectangle.");
                }
                else if(e.Y == 10 || e.Y == Height - 10)
                {
                    if (e.X >= 10 && e.X <= Width - 10)
                        MessageBox.Show("Border of rectangle.");
                }
                else MessageBox.Show("Rectangle.");
            }
            else if (e.Button == MouseButtons.Right)
            {
                frm.Text = String.Format($"Width = {Width}  Height = {Height}");
            }
        }
    }
}
