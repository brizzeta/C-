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
    public partial class Form_Edit : Form
    {
        public Form Parent_form1 { get; set; }
        public Form_Edit()
        {
            InitializeComponent();
        }
        public string Pay
        {
            get
            {
                if (!String.IsNullOrEmpty(textBox1.Text))
                    return textBox1.Text;
                throw new Exception("Error.");
            }
            set
            {
                textBox1.Text = value;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Pay = textBox1.Text;
        }
    }
}
