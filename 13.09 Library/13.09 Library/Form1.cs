using static System.Reflection.Metadata.BlobBuilder;

namespace _13._09_Library
{
    public partial class Form1 : Form, IView
    {

        public event Action<string> AddAuthor;
        public event Action<string, string> AddBook;
        public event Action<string> Filter;
        public event Action<string> DeleteAuthor;
        public event Action<string, string> EditAuthor;
        public event Action<string, string> EditBook;
        public event Action<string> DeleteBook;
        public event EventHandler<EventArgs> Save;
        public event EventHandler<EventArgs> Load;

        public Form1()
        {
            InitializeComponent();
        }

        void IView.DisplayAuthors(List<string> authors)
        {
            AuthotComboBox.Items.Clear();
            foreach (var author in authors)
            {
                AuthotComboBox.Items.Add(author);
            }
            if (AuthotComboBox.Items.Count > 0)
            {
                AuthotComboBox.SelectedIndex = 0;
            }
        }

        void IView.DisplayBooks(List<string> books)
        {
            BookList.Items.Clear();
            foreach (var i in books)
            {
                BookList.Items.Add(i);
            }
        }

        void IView.DisplayFiltered(List<string> books)
        {
            BookList.Items.Clear();
            foreach (var i in books)
            {
                BookList.Items.Add(i);
            }
        }
        void IView.Error(string message)
        {
            MessageBox.Show(message, "Library");
        }

        private void AddAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var addAuthorForm = new textBox1())
            {
                if (addAuthorForm.ShowDialog() == DialogResult.OK)
                {
                    AddAuthor?.Invoke(addAuthorForm.Name);
                }
            }
        }

        private void AddBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var AddBooksForm = new AddBooks())
            {
                if (AddBooksForm.ShowDialog() == DialogResult.OK)
                {
                    AddBook?.Invoke(AuthotComboBox.SelectedItem.ToString(), AddBooksForm.Name);
                }
            }
        }

        private void DeleteAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AuthotComboBox.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Вы точно что хотите удалить автора?", "Library", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string selectedAuthor = AuthotComboBox.SelectedItem.ToString();
                    DeleteAuthor?.Invoke(selectedAuthor);
                }

            }
        }

        private void EditAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var EditAuthorForm = new EditAuthor(AuthotComboBox.SelectedItem.ToString()))
            {
                if (EditAuthorForm.ShowDialog() == DialogResult.OK)
                {
                    EditAuthor?.Invoke(AuthotComboBox.SelectedItem.ToString(), EditAuthorForm.NewName);
                }
            }
        }

        private void EditBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var EditBookForm = new EditBook(BookList.SelectedItem.ToString()))
            {
                if (EditBookForm.ShowDialog() == DialogResult.OK)
                {
                    EditBook?.Invoke(BookList.SelectedItem.ToString(), EditBookForm.NewName);
                }
            }
        }

        private void DeleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BookList.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Вы точно хотите удалить книгу?", "Library", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string selectedBook = BookList.SelectedItem.ToString();
                    DeleteBook?.Invoke(selectedBook);
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save?.Invoke(this, EventArgs.Empty);
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Load?.Invoke(this, EventArgs.Empty);
        }

        private void Filtre_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtre.Checked == true)
            {
                if (AuthotComboBox.SelectedItem != null)
                {
                    Filter?.Invoke(AuthotComboBox.SelectedItem.ToString());
                }
            }
            else
            {
                Filter?.Invoke(null);
            }
        }

        private void AuthotComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Filtre.Checked == true)
            {
                if (AuthotComboBox.SelectedItem != null)
                {
                    Filter?.Invoke(AuthotComboBox.SelectedItem.ToString());
                }
            }
        }
    }
}