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

namespace _3.Task
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
            double res;
            try
            {
                res  = (double.Parse(text0.Text) * double.Parse(text4.Text) * double.Parse(text8.Text)) 
                     - (double.Parse(text0.Text) * double.Parse(text5.Text) * double.Parse(text7.Text)) 
                     - (double.Parse(text1.Text) + double.Parse(text3.Text) + double.Parse(text8.Text)) 
                     + (double.Parse(text1.Text) + double.Parse(text5.Text) + double.Parse(text6.Text))
                     + (double.Parse(text2.Text) + double.Parse(text3.Text) + double.Parse(text7.Text))
                     - (double.Parse(text2.Text) + double.Parse(text4.Text) + double.Parse(text6.Text));
                result.Text = res.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
