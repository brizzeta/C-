using System;
using System.Windows.Forms;

namespace _14._04.WinForms_Millioner_GAME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Меню

            MainMenu MyMenu = new MainMenu();

            MenuItem m1 = new MenuItem("Игра");
            m1.Select += new EventHandler(subm1_Select);
            MyMenu.MenuItems.Add(m1);

            MenuItem m2 = new MenuItem("Администраторский режим");
            m2.Select += new EventHandler(subm1_Select);
            MyMenu.MenuItems.Add(m2);

            MenuItem m3 = new MenuItem("О програме");
            m3.Select += new EventHandler(subm1_Select);
            MyMenu.MenuItems.Add(m3);
            Menu = MyMenu;
        }


    }
}
