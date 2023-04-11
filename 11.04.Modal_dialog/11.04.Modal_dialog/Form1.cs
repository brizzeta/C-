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
    public partial class Form1 : Form
    {
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
        }
        public string Text
        {
            set
            {
                textBox2.Text = value;
            }
            get
            {
                if (!String.IsNullOrEmpty(textBox1.Text))
                    return textBox1.Text;
                throw new Exception("Error.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Parent_form1 = this;
            form2.Text = Text;

            DialogResult res = form2.ShowDialog();
            if (res == DialogResult.OK)
            {
                Text = form2.Text;
            }
        }
    }
}
