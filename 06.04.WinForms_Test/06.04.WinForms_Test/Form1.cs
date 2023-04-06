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

namespace _06._04.WinForms_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Maximum = 10;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            double res = 0;
            if(checkBox2.Checked == true)
            {
                res += 0.5;
            }
            if(checkBox4.Checked == true)
            {
                res += 0.5;
            }
            if (checkBox5.Checked == true)
            {
                res += 0.33;
            }
            if (checkBox7.Checked == true)
            {
                res += 0.33;
            }
            if (checkBox8.Checked == true)
            {
                res += 0.33;
            }
            if (checkBox9.Checked == true)
            {
                res += 0.33;
            }
            if (checkBox11.Checked == true)
            {
                res += 0.33;
            }
            if (checkBox12.Checked == true)
            {
                res += 0.33;
            }
            if (checkBox15.Checked == true)
            {
                res += 1;
            }
            if (checkBox17.Checked == true)
            {
                res += 0.33;
            }
            if (checkBox19.Checked == true)
            {
                res += 0.33;
            }
            if (checkBox20.Checked == true)
            {
                res += 0.33;
            }
            if (checkBox21.Checked == true)
            {
                res += 0.5;
            }
            if (checkBox22.Checked == true)
            {
                res += 0.5;
            }
            if (radioButton2.Checked == true)
            {
                res += 1;
            }
            if (radioButton4.Checked == true)
            {
                res += 1;
            }
            if (radioButton7.Checked == true)
            {
                res += 1;
            }            
            if (radioButton10.Checked == true)
            {
                res += 1;
            }

            progressBar1.Value = (int)Math.Ceiling(res);

            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter write = new StreamWriter("Results.txt"))
                write.WriteLine("Results: " + progressBar1.Value + "/10");
        }
    }
}
