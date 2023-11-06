using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _16._10_Notebook
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Add(object sender, ExecutedRoutedEventArgs e)
        {
            NotebookInformation notebookinformation = Resources["notebook"] as NotebookInformation;
            Notebook note = new Notebook();
            note.FullName = notebookinformation.InfoFullName;
            note.Address = notebookinformation.InfoAddress;
            note.Phone = notebookinformation.InfoPhone;
            notebookinformation.InfoPhone = string.Empty;
            notebookinformation.InfoFullName = string.Empty;
            notebookinformation.InfoAddress = string.Empty;
            notebookinformation.Notebooks.Add(note);
        }

        private void AddExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            NotebookInformation notebookinformation = Resources["notebook"] as NotebookInformation;
            if (notebookinformation.InfoFullName != string.Empty && notebookinformation.InfoAddress != string.Empty && notebookinformation.InfoPhone != string.Empty)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void Delete(object sender, ExecutedRoutedEventArgs e)
        {
            NotebookInformation notebookinformation = Resources["notebook"] as NotebookInformation;
            notebookinformation.Notebooks.RemoveAt(notebookinformation.Index_selected_listbox);
            notebookinformation.InfoPhone = string.Empty;
            notebookinformation.InfoFullName = string.Empty;
            notebookinformation.InfoAddress = string.Empty;
        }

        private void DeleteExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            NotebookInformation notebookinformation = Resources["notebook"] as NotebookInformation;
            if (notebookinformation.Index_selected_listbox == -1)
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                NotebookInformation notebookinformation = Resources["notebook"] as NotebookInformation;
                if (notebookinformation.Index_selected_listbox == -1)
                {
                    return;
                }
                Notebook note = notebookinformation.Notebooks[notebookinformation.Index_selected_listbox];
                notebookinformation.InfoPhone = note.Phone;
                notebookinformation.InfoAddress = note.Address;
                notebookinformation.InfoFullName = note.FullName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Edit(object sender, ExecutedRoutedEventArgs e)
        {
            NotebookInformation notebookinformation = Resources["notebook"] as NotebookInformation;
            Notebook note = new Notebook();
            note.FullName = notebookinformation.InfoFullName;
            note.Address = notebookinformation.InfoAddress;
            note.Phone = notebookinformation.InfoPhone;
            notebookinformation.InfoPhone = string.Empty;
            notebookinformation.InfoFullName = string.Empty;
            notebookinformation.InfoAddress = string.Empty;
            notebookinformation.Notebooks.Insert(notebookinformation.Index_selected_listbox, note);
            notebookinformation.Notebooks.RemoveAt(notebookinformation.Index_selected_listbox);
        }

        private void EditExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            NotebookInformation notebookinformation = Resources["notebook"] as NotebookInformation;
            if (notebookinformation.Index_selected_listbox == -1)
            {

                e.CanExecute = false;
            }
            else
            {
                if (notebookinformation.InfoFullName != string.Empty && notebookinformation.InfoAddress != string.Empty && notebookinformation.InfoPhone != string.Empty)
                    e.CanExecute = true;
            }
        }

        private void SaveJson(object sender, ExecutedRoutedEventArgs e)
        {
            try
            {
                NotebookInformation notebookinformation = Resources["notebook"] as NotebookInformation;
                using (StreamWriter wr = new StreamWriter("Notebook.json"))
                {
                    wr.WriteLine(JsonSerializer.Serialize(notebookinformation.Notebooks));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveJsonExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            NotebookInformation notebookinformation = Resources["notebook"] as NotebookInformation;
            if (notebookinformation.Notebooks.Count != 0)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void LoadJson(object sender, ExecutedRoutedEventArgs e)
        {
            try
            {
                NotebookInformation notebookinformation = Resources["notebook"] as NotebookInformation;
                using (StreamReader read = new StreamReader("Notebook.json"))
                {
                    notebookinformation.Notebooks = JsonSerializer.Deserialize<ObservableCollection<Notebook>>(read.ReadToEnd());
                    Dispatcher.Invoke(() => Info.ItemsSource = notebookinformation.Notebooks);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    public class Notebook : INotifyPropertyChanged
    {
        private string fullname;
        private string address;
        private string phone;

        public string FullName
        {
            get
            {
                return fullname;
            }
            set
            {
                fullname = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(FullName)));
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Address)));
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Phone)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }

    public class NotebookInformation : INotifyPropertyChanged
    {
        public ObservableCollection<Notebook> Notebooks { get; set; } = new ObservableCollection<Notebook>();

        private int index_selected_listbox = -1;

        public int Index_selected_listbox
        {
            get { return index_selected_listbox; }
            set
            {
                index_selected_listbox = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Index_selected_listbox)));
            }
        }

        private string fullname;
        private string address;
        private string phone;

        public string InfoFullName
        {
            get
            {
                return fullname;
            }
            set
            {
                fullname = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(InfoFullName)));
            }
        }
        public string InfoAddress
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(InfoAddress)));
            }
        }
        public string InfoPhone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(InfoPhone)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }

    public class AddCommand
    {
        private static RoutedUICommand add;

        static AddCommand()
        {
            InputGestureCollection input = new InputGestureCollection();
            input.Add(new KeyGesture(Key.A, ModifierKeys.Control, "Ctrl+A"));
            add = new RoutedUICommand("Добавить", "Add", typeof(AddCommand), input);
        }

        public static RoutedUICommand Add
        {
            get { return add; }
        }
    }

    public class DeleteCommand
    {
        private static RoutedUICommand delete;

        static DeleteCommand()
        {
            InputGestureCollection input = new InputGestureCollection();
            input.Add(new KeyGesture(Key.D, ModifierKeys.Control, "Ctrl+D"));
            delete = new RoutedUICommand("Удалить", "Del", typeof(DeleteCommand), input);
        }

        public static RoutedUICommand Delete
        {
            get { return delete; }
        }
    }

    public class EditCommand
    {
        private static RoutedUICommand edit;

        static EditCommand()
        {
            InputGestureCollection input = new InputGestureCollection();
            input.Add(new KeyGesture(Key.E, ModifierKeys.Control, "Ctrl+E"));
            edit = new RoutedUICommand("Редактировать", "Edit", typeof(EditCommand), input);
        }

        public static RoutedUICommand Edit
        {
            get { return edit; }
        }
    }

    public class SaveJson
    {
        private static RoutedUICommand save;

        static SaveJson()
        {
            InputGestureCollection input = new InputGestureCollection();
            input.Add(new KeyGesture(Key.S, ModifierKeys.Control, "Ctrl+S"));
            save = new RoutedUICommand("Сохранить", "Save", typeof(SaveJson), input);
        }

        public static RoutedUICommand Save
        {
            get { return save; }
        }
    }

    public class LoadJson
    {
        private static RoutedUICommand load;

        static LoadJson()
        {
            InputGestureCollection input = new InputGestureCollection();
            input.Add(new KeyGesture(Key.L, ModifierKeys.Control, "Ctrl+L"));
            load = new RoutedUICommand("Загрузить", "Load", typeof(LoadJson), input);
        }

        public static RoutedUICommand Load
        {
            get { return load; }
        }
    }

    public class CommandSelection
    {
        private static RoutedUICommand selection;

        static CommandSelection()
        {
            InputGestureCollection input = new InputGestureCollection();
            selection = new RoutedUICommand("Выбор", "Selection", typeof(CommandSelection), input);
        }

        public static RoutedUICommand Selection
        {
            get { return selection; }
        }
    }
}
