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
    public partial class Form1 : Form
    {
        Form_Cafe Cafe;
        Form_Gas Gas;
        Form_Edit Edit;
        public Form1()
        {
            InitializeComponent();

            //Main menu

            MainMenu MyMenu = new MainMenu();

            MenuItem m1 = new MenuItem("Next client");
            m1.Select += new EventHandler(subm1_Select);
            MyMenu.MenuItems.Add(m1);

            MenuItem m2 = new MenuItem("Clean");
            m2.Select += new EventHandler(subm1_Select);
            MyMenu.MenuItems.Add(m2);

            MenuItem m3 = new MenuItem("Exit");
            m3.Select += new EventHandler(subm1_Select);
            MyMenu.MenuItems.Add(m3);
            Menu = MyMenu;

            //Context menu

            ContextMenuStrip Cont = new ContextMenuStrip();

            ToolStripMenuItem m1_cont = new ToolStripMenuItem();
            m1_cont.Text = "Next client";
            m1_cont.Click += new EventHandler(subm2_Select);

            ToolStripMenuItem m2_cont = new ToolStripMenuItem();
            m2_cont.Text = "Clean";
            m2_cont.Click += new EventHandler(subm2_Select);

            ToolStripMenuItem m3_cont = new ToolStripMenuItem();
            m3_cont.Text = "Exit";
            m3_cont.Click += new EventHandler(subm2_Select);

            Cont.Items.Add(m1_cont);
            Cont.Items.Add(m2_cont);
            Cont.Items.Add(m3_cont);

            ContextMenuStrip = Cont;
        }

        private void subm2_Select(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if (item.Text == "Next client" || item.Text == "Clean")
            {
                label12.Text = "0";
            }
            else
            {
                Close();
            }
        }

        private void subm1_Select(object sender, EventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            if(item.Index == 0 || item.Index == 1)
            {
                label12.Text = "0";
            }
            else
            {
                Close();
            }
        }

        public string Pay {
            get
            {
                if (!String.IsNullOrEmpty(label12.Text))
                    return label12.Text;
                throw new Exception("Error.");
            }
            set
            {
                label12.Text = value;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cafe = new Form_Cafe();
            Cafe.Parent_form1 = this;

            DialogResult res = Cafe.ShowDialog();
            if (res == DialogResult.OK)
            {
                Pay = Convert.ToString(Convert.ToDouble(Pay) + Convert.ToDouble(Cafe.Pay));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gas = new Form_Gas();
            Gas.Parent_form1 = this;

            DialogResult res = Gas.ShowDialog();
            if (res == DialogResult.OK)
            {
                Pay = Convert.ToString(Convert.ToDouble(Pay) + Convert.ToDouble(Gas.Pay));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Edit = new Form_Edit();
            Edit.Parent_form1 = this;
            Edit.Pay = Pay;

            DialogResult res = Edit.ShowDialog();
            if (res == DialogResult.OK)
            {
                Pay = Edit.Pay;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "To pay: " + Pay + ".";
            System.IO.File.WriteAllText("pay.txt", text);
            MessageBox.Show("Thank you! Goodbye.", "BestOil", MessageBoxButtons.OK);
            Close();
        }
    }
}
