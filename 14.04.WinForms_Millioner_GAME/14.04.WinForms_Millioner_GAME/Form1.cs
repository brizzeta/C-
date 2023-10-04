using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _14._04.WinForms_Millioner_GAME
{
    public partial class Form1 : Form
    {
        int Num;          // number of question
        XDocument reader;
        List<TextBox> textBoxes = new List<TextBox>();
        string[] bool_answ = new string[4];
        public Form1()
        {
            InitializeComponent();
            Num = 1;
            reader = XDocument.Load("questions.xml");

            textBoxes.Add(textBox2);
            textBoxes.Add(textBox3);
            textBoxes.Add(textBox4);
            textBoxes.Add(textBox5);

            // listBox

            int balls = 3900;
            for(int i = 38; i >= 0; i--, balls-=100)
            {
                listBox1.Items.Add((balls * 100).ToString() + " — " + (i + 1).ToString());
            }
            listBox1.SelectedIndex = 38;

            // Меню

            MainMenu MyMenu = new MainMenu();

            MenuItem m1 = new MenuItem("Игра");
            //m1.Select += new EventHandler(subm_Play);
            MyMenu.MenuItems.Add(m1);

            MenuItem m2 = new MenuItem("Администраторский режим");
            //m2.Select += new EventHandler(subm_Admin);
            MyMenu.MenuItems.Add(m2);

            MenuItem m3 = new MenuItem("О програме");
            //m3.Select += new EventHandler(subm_About);
            MyMenu.MenuItems.Add(m3);
            Menu = MyMenu;

            NewQuest();
        }

        // new question
        void NewQuest()
        {
            XElement quests = reader.Element("questions");

            //проходим по всем элементам questions
            foreach (XElement quest in quests.Elements("question"))
            {

                if (quest.Attribute("num").Value == Num.ToString())
                {
                    textBox1.Text = quest.Attribute("text").Value;

                    int i = 0;

                    foreach (XElement answ in quest.Elements("answ"))
                    {
                        textBoxes[i].Text = answ.Value;
                        bool_answ[i] = answ.Attribute("true").Value;
                        i++;
                    }
                    break;
                }
            }
        }

        //private void textBox2_Click(object sender, EventArgs e)
        //{

        //}
    }
}
