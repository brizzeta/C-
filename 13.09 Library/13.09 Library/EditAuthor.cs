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
    public partial class EditAuthor : Form
    {
        public string NewName { get; set; }

        public EditAuthor(string Autor)
        {
            InitializeComponent();
            textBox.Text = Autor;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            NewName = textBox.Text;
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
