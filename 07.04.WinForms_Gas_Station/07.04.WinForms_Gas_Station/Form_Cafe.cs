using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _07._04.WinForms_Gas_Station
{
    public partial class Form_Cafe : Form
    {
        public Form Parent_form1 { get; set; }
        public Form_Cafe()
        {
            InitializeComponent();
        }

        public string Pay
        {
            get
            {
                if (!String.IsNullOrEmpty(label9.Text))
                    return label9.Text;
                throw new Exception("Error.");
            }
            set
            {
                label9.Text = value;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox4.Enabled = true;
            }
            else
            {
                textBox4.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox10.Enabled = true;
            }
            else
            {
                textBox10.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox6.Enabled = true;
            }
            else
            {
                textBox6.Enabled = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox8.Enabled = true;
            }
            else
            {
                textBox8.Enabled = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double text1 = Convert.ToDouble(Pay);
            double text2 = Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox4.Text);
            Pay = Convert.ToString(text1 + text2);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            double text1 = Convert.ToDouble(Pay);
            double text2 = Convert.ToDouble(textBox11.Text) * Convert.ToDouble(textBox10.Text);
            Pay = Convert.ToString(text1 + text2);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            double text1 = Convert.ToDouble(Pay);
            double text2 = Convert.ToDouble(textBox7.Text) * Convert.ToDouble(textBox6.Text);
            Pay = Convert.ToString(text1 + text2);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            double text1 = Convert.ToDouble(Pay);
            double text2 = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox8.Text);
            Pay = Convert.ToString(text1 + text2);
        }
    }
}
