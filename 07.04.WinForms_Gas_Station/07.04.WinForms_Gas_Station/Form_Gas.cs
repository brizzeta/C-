using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _07._04.WinForms_Gas_Station
{
    public partial class Form_Gas : Form
    {
        public Form Parent_form1 { get; set; }
        public Form_Gas()
        {
            InitializeComponent();
            comboBox1.Items.Add("A-92");
            comboBox1.Items.Add("A-95");
            comboBox1.SelectedIndex = 0;
        }

        public string Pay
        {
            get
            {
                if (!String.IsNullOrEmpty(label6.Text))
                    return label6.Text;
                throw new Exception("Error.");
            }
            set
            {
                label6.Text = value;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                textBox1.Text = "48,25";
            }
            else
            {
                textBox1.Text = "49,02";
            }

            if(radioButton1.Checked)
            {
                textBox2.Text = "0";
            }
            else if(radioButton2.Checked)
            {
                textBox3.Text = "0";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox3.Text = string.Empty;
                textBox2.Enabled = true;                
                textBox3.Enabled = false;                
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.Text = string.Empty;
                textBox2.Enabled = false;                
                textBox3.Enabled = true;                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text == string.Empty)
            {
                Pay = "0";
            }
            else
                Pay = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text));
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == string.Empty)
            {
                Pay = "0";
            }
            else
                Pay = textBox3.Text;
        }
    }
}
