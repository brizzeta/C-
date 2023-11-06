using System;
using System.Collections.Generic;
using System.Data;
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

namespace _4._10_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button buttclicked = (Button)sender;
            switch (buttclicked.Content)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    if (textBlock1.Text.Contains("="))
                    {
                        textBlock1.Text = string.Empty;
                        textBlock1.Text += textBlock2.Text + buttclicked.Content;
                        textBlock2.Text = string.Empty;
                    }
                    else if (textBlock2.Text == "Division by zero is impossible")
                    {
                        MessageBox.Show("Enter digit");
                        textBlock2.Text = string.Empty;
                    }
                    else
                    {
                        textBlock1.Text += textBlock2.Text + buttclicked.Content;
                        textBlock2.Text = string.Empty;
                    }
                    break;
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case ".":
                    if (textBlock2.Text.Contains("0"))
                    {
                        int index = textBlock2.Text.IndexOf("0");
                        if(index != 0 || textBlock2.Text.Contains("."))
                        {
                            textBlock2.Text += buttclicked.Content;
                        }
                        else if(buttclicked.Content.ToString() == ".")
                        {
                            textBlock2.Text += buttclicked.Content;
                        }
                    }
                    else
                    {
                        if (textBlock2.Text == "Division by zero is impossible")
                        {
                            textBlock1.Text = string.Empty;
                            textBlock2.Text = string.Empty;
                            textBlock2.Text += buttclicked.Content;
                        }
                        else
                        {
                            textBlock2.Text += buttclicked.Content;
                        }
                    }
                    break;
                case "CE":
                    textBlock1.Text = string.Empty;
                    textBlock2.Text = string.Empty;
                    break;
                case "C":
                    textBlock2.Text = string.Empty;
                    break;
                case "<":
                    textBlock2.Text = textBlock2.Text.Substring(0, textBlock2.Text.Length - 1);
                    break;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (textBlock2.Text != string.Empty && textBlock1.Text.Contains("=") == false)
                {
                    textBlock1.Text += textBlock2.Text;
                    textBlock2.Text = string.Empty;
                }
                if (textBlock1.Text.Contains("="))
                {
                    return;
                }
                if (textBlock1.Text.Contains("/0"))
                {
                    textBlock2.Text = "Division by zero is impossible";
                    throw new DivideByZeroException();
                }
                textBlock2.Text = new DataTable().Compute(textBlock1.Text, null).ToString();
                textBlock1.Text += "=";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
