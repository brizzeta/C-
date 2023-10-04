using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13._09_Library
{
    public partial class EditBook : Form
    {

        public string NewName { get; set; }

        public EditBook(string Book)
        {
            InitializeComponent();
            textBox1.Text = Book;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewName = textBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
