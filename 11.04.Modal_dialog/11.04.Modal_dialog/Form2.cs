using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._04.Modal_dialog
{
    public partial class Form2 : Form
    {
        public Form Parent_form1 { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        public string Text
        {
            set
            {
                textBox1.Text = value;
            }
            get
            {
                if(!String.IsNullOrEmpty(textBox2.Text))
                    return textBox2.Text;
                throw new Exception("Error.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
