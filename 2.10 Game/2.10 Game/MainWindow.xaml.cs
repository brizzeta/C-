using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _2._10_Game
{
    public partial class MainWindow : Window
    {
        DispatcherTimer time;
        List<int> digit;
        List<Button> butt;
        public MainWindow()
        {
            InitializeComponent();
            butt = new List<Button>() { butt1, butt2, butt3, butt4, butt5, butt6, butt7, butt8, butt9, butt10, butt11, butt12, butt13, butt14, butt15, butt16 };
            digit = new List<int>();
            time = new DispatcherTimer();
            time.Tick += new EventHandler(timer_tick);
            time.Interval = new TimeSpan(0, 0, 1);
        }

        private void timer_tick(object sender, EventArgs e)
        {
            progresstime.Value++;
            if (progresstime.Value == progresstime.Maximum)
            {
                for (int i = 0; i < butt.Count; i++)
                {
                    butt[i].IsEnabled = false;
                }
                time.Stop();
                MessageBox.Show("You lose");
            }
        }

        private void butt1_Click(object sender, RoutedEventArgs e)
        {
            Button clickedbutton = (Button)sender;
            if(int.Parse(clickedbutton.Content.ToString()) == digit.Min())
            {
                digit.Remove(digit.Min());
                clickedbutton.IsEnabled = false;
                numBox.Items.Add(clickedbutton.Content.ToString());
                if(digit.Count == 0)
                {
                    time.Stop();
                    MessageBox.Show("You Win");
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (time1.IsChecked == true)
            {
                progresstime.Maximum = 15;
            }
            else if (time2.IsChecked == true)
            {
                progresstime.Maximum = 30;
            }
            else if (time3.IsChecked == true)
            {
                progresstime.Maximum = 45;
            }
            else if (time4.IsChecked == true)
            {
                progresstime.Maximum = 60;
            }
            digit.Clear();
            numBox.Items.Clear();
            Random rand = new Random();
            for(int i = 0; i < butt.Count; i++)
            {
                digit.Add(rand.Next(100));
            }
            for (int i = 0; i < butt.Count; i++)
            {
                butt[i].Content = digit[i].ToString();
                butt[i].IsEnabled = true;
            }
            progresstime.Value = 0;
            time.Start();
        }
    }
}
