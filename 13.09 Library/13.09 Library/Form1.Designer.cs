namespace _13._09_Library
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            LoadToolStripMenuItem = new ToolStripMenuItem();
            опцииToolStripMenuItem = new ToolStripMenuItem();
            AddAuthorToolStripMenuItem = new ToolStripMenuItem();
            EditAuthorToolStripMenuItem = new ToolStripMenuItem();
            DeleteAuthorToolStripMenuItem = new ToolStripMenuItem();
            AddBooksToolStripMenuItem = new ToolStripMenuItem();
            EditBooksToolStripMenuItem = new ToolStripMenuItem();
            DeleteBookToolStripMenuItem = new ToolStripMenuItem();
            AuthotComboBox = new ComboBox();
            BookList = new ListBox();
            Filtre = new CheckBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, опцииToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(447, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SaveToolStripMenuItem, LoadToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Size = new Size(133, 22);
            SaveToolStripMenuItem.Text = "Сохранить";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // LoadToolStripMenuItem
            // 
            LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            LoadToolStripMenuItem.Size = new Size(133, 22);
            LoadToolStripMenuItem.Text = "Загрузить";
            LoadToolStripMenuItem.Click += LoadToolStripMenuItem_Click;
            // 
            // опцииToolStripMenuItem
            // 
            опцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddAuthorToolStripMenuItem, EditAuthorToolStripMenuItem, DeleteAuthorToolStripMenuItem, AddBooksToolStripMenuItem, EditBooksToolStripMenuItem, DeleteBookToolStripMenuItem });
            опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            опцииToolStripMenuItem.Size = new Size(56, 20);
            опцииToolStripMenuItem.Text = "Опции";
            // 
            // AddAuthorToolStripMenuItem
            // 
            AddAuthorToolStripMenuItem.Name = "AddAuthorToolStripMenuItem";
            AddAuthorToolStripMenuItem.Size = new Size(203, 22);
            AddAuthorToolStripMenuItem.Text = "Добавление автора";
            AddAuthorToolStripMenuItem.Click += AddAuthorToolStripMenuItem_Click;
            // 
            // EditAuthorToolStripMenuItem
            // 
            EditAuthorToolStripMenuItem.Name = "EditAuthorToolStripMenuItem";
            EditAuthorToolStripMenuItem.Size = new Size(203, 22);
            EditAuthorToolStripMenuItem.Text = "Редактирование автора";
            EditAuthorToolStripMenuItem.Click += EditAuthorToolStripMenuItem_Click;
            // 
            // DeleteAuthorToolStripMenuItem
            // 
            DeleteAuthorToolStripMenuItem.Name = "DeleteAuthorToolStripMenuItem";
            DeleteAuthorToolStripMenuItem.Size = new Size(203, 22);
            DeleteAuthorToolStripMenuItem.Text = "Удаление автора";
            DeleteAuthorToolStripMenuItem.Click += DeleteAuthorToolStripMenuItem_Click;
            // 
            // AddBooksToolStripMenuItem
            // 
            AddBooksToolStripMenuItem.Name = "AddBooksToolStripMenuItem";
            AddBooksToolStripMenuItem.Size = new Size(203, 22);
            AddBooksToolStripMenuItem.Text = "Добавление книги";
            AddBooksToolStripMenuItem.Click += AddBooksToolStripMenuItem_Click;
            // 
            // EditBooksToolStripMenuItem
            // 
            EditBooksToolStripMenuItem.Name = "EditBooksToolStripMenuItem";
            EditBooksToolStripMenuItem.Size = new Size(203, 22);
            EditBooksToolStripMenuItem.Text = "Редактирование книги";
            EditBooksToolStripMenuItem.Click += EditBooksToolStripMenuItem_Click;
            // 
            // DeleteBookToolStripMenuItem
            // 
            DeleteBookToolStripMenuItem.Name = "DeleteBookToolStripMenuItem";
            DeleteBookToolStripMenuItem.Size = new Size(203, 22);
            DeleteBookToolStripMenuItem.Text = "Удаление книги";
            DeleteBookToolStripMenuItem.Click += DeleteBookToolStripMenuItem_Click;
            // 
            // AuthotComboBox
            // 
            AuthotComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AuthotComboBox.FormattingEnabled = true;
            AuthotComboBox.Location = new Point(12, 27);
            AuthotComboBox.Name = "AuthotComboBox";
            AuthotComboBox.Size = new Size(423, 23);
            AuthotComboBox.TabIndex = 1;
            AuthotComboBox.SelectedIndexChanged += AuthotComboBox_SelectedIndexChanged;
            // 
            // BookList
            // 
            BookList.FormattingEnabled = true;
            BookList.ItemHeight = 15;
            BookList.Location = new Point(12, 56);
            BookList.Name = "BookList";
            BookList.Size = new Size(423, 184);
            BookList.TabIndex = 2;
            // 
            // Filtre
            // 
            Filtre.AutoSize = true;
            Filtre.Location = new Point(178, 246);
            Filtre.Name = "Filtre";
            Filtre.Size = new Size(93, 19);
            Filtre.TabIndex = 3;
            Filtre.Text = "Фильтрация";
            Filtre.UseVisualStyleBackColor = true;
            Filtre.CheckedChanged += Filtre_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 268);
            Controls.Add(Filtre);
            Controls.Add(BookList);
            Controls.Add(AuthotComboBox);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem LoadToolStripMenuItem;
        private ToolStripMenuItem опцииToolStripMenuItem;
        private ToolStripMenuItem AddAuthorToolStripMenuItem;
        private ToolStripMenuItem EditAuthorToolStripMenuItem;
        private ToolStripMenuItem DeleteAuthorToolStripMenuItem;
        private ToolStripMenuItem AddBooksToolStripMenuItem;
        private ToolStripMenuItem EditBooksToolStripMenuItem;
        private ToolStripMenuItem DeleteBookToolStripMenuItem;
        private ComboBox AuthotComboBox;
        private ListBox BookList;
        private CheckBox Filtre;
    }
}