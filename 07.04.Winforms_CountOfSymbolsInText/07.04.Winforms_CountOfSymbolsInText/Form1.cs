using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07._04.Winforms_CountOfSymbolsInText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Maximum = 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = File.ReadAllText("1.txt");
            progressBar1.Value = path.Length;
        }
    }
}
