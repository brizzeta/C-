using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Newtonsoft.Json;

namespace _1._11_Resume
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<string> ComboPersons { get; set; }
        public ObservableCollection<PersonViewModel> ListPersons { get; set; }
        private ObservableCollection<PersonViewModel> temp_list = new ObservableCollection<PersonViewModel>();
        private PersonViewModel current;
        private int combo_index;
        private Commands? add, select, clear, remove, save;
        public MainViewModel()
        {
            ComboPersons = new ObservableCollection<string>();
            ListPersons = new ObservableCollection<PersonViewModel>();
            Current = new PersonViewModel();
            LoadFromFile();
        }
        public PersonViewModel Current
        {
            get { return current; }
            set
            {
                current = value;
                OnPropertyChanged(nameof(Current));
            }
        }
        public int ComboIndex
        {
            get { return combo_index; }
            set
            {
                if (combo_index != value)
                {
                    combo_index = value;
                    OnPropertyChanged(nameof(ComboIndex));
                }
            }
        }
        private void LoadFromFile()
        {
            try
            {
                if (File.Exists("Resume.json") && File.Exists("Combo.json"))
                {
                    string json = File.ReadAllText("Resume.json");
                    temp_list = JsonConvert.DeserializeObject<ObservableCollection<PersonViewModel>>(json);
                    json = File.ReadAllText("Combo.json");
                    ComboPersons = JsonConvert.DeserializeObject<ObservableCollection<string>>(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public ICommand AddCommand
        {
            get
            {
                if (add == null) add = new Commands(execute => Add(), can => CanAdd());
                return add;
            }
        }
        private void Add()
        {
            ComboPersons.Add(Current.ComboText());
            temp_list.Add(Current.Clone());
            Current.Fullname = string.Empty;
            Current.Age = string.Empty;
            Current.Family = string.Empty;
            Current.Address = string.Empty;
            Current.Email = string.Empty;
            Current.Check1 = false;
            Current.Check2 = false;
            Current.Check3 = false;
            Current.Check4 = false;
            Current.Check5 = false;
        }
        private bool CanAdd() { return !current.IsEmpty(); }
        public ICommand SelectCommand
        {
            get
            {
                if (select == null) select = new Commands(execute => Select(), can => CanSelect());
                return select;
            }
        }
        private void Select()
        {
            ListPersons.Clear();
            ListPersons.Add(temp_list[ComboIndex]);
        }
        private bool CanSelect() { return ComboPersons.Count > 0; }
        public ICommand ClearCommand
        {
            get
            {
                if (clear == null)
                    clear = new Commands(execute => Clear(), can => CanClear());
                return clear;
            }
        }
        private void Clear() => ListPersons.Clear();
        private bool CanClear() { return ComboPersons.Count > 0 && ListPersons.Count > 0; }
        public ICommand RemoveCommand
        {
            get
            {
                if (remove == null) 
                    remove = new Commands(execute => Remove(), can => CanRemove());
                return remove;
            }
        }
        private void Remove()
        {
            MessageBoxResult res = MessageBox.Show("Вы хотите удалить резюме?", "Resume", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (res == MessageBoxResult.Yes)
            {
                ComboPersons.RemoveAt(ComboIndex);
                ListPersons.Clear();
            }
        }
        private bool CanRemove() { return ComboPersons.Count > 0; }
        public ICommand SaveCommand
        {
            get
            {
                if (save == null) save = new Commands(execute => SaveToFile(), can => CanSave());
                return save;
            }
        }
        private void SaveToFile()
        {
            try
            {
                string json = JsonConvert.SerializeObject(temp_list, Formatting.Indented);
                File.WriteAllText("Resume.json", json);
                json = JsonConvert.SerializeObject(ComboPersons, Formatting.Indented);
                File.WriteAllText("Combo.json", json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool CanSave() { return temp_list.Count > 0; }
    }
    public class PersonViewModel : BaseViewModel
    {
        private Resume model;
        private bool check1, check2, check3, check4, check5;
        public PersonViewModel() => model = new Resume();
        public bool Check1
        {
            get { return check1; }
            set
            {
                check1 = value;
                OnPropertyChanged(nameof(Check1));
            }
        }
        public bool Check2
        {
            get { return check2; }
            set
            {
                check2 = value;
                OnPropertyChanged(nameof(Check2));
            }
        }
        public bool Check3
        {
            get { return check3; }
            set
            {
                check3 = value;
                OnPropertyChanged(nameof(Check3));
            }
        }
        public bool Check4
        {
            get { return check4; }
            set
            {
                check4 = value;
                OnPropertyChanged(nameof(Check4));
            }
        }
        public bool Check5
        {
            get { return check5; }
            set
            {
                check5 = value;
                OnPropertyChanged(nameof(Check5));
            }
        }
        public Resume Model
        {
            get { return model; }
            set
            {
                model = value;
                OnPropertyChanged(nameof(Model));
            }
        }
        public string Fullname
        {
            get { return model.Fullname; }
            set
            {
                model.Fullname = value;
                OnPropertyChanged(nameof(Fullname));
            }
        }
        public string Age
        {
            get { return model.Age; }
            set
            {
                model.Age = value;
                OnPropertyChanged(nameof(Age));
            }
        }
        public string Family
        {
            get { return model.Family; }
            set
            {
                model.Family = value;
                OnPropertyChanged(nameof(Family));
            }
        }
        public string Address
        {
            get { return model.Address; }
            set
            {
                model.Address = value;
                OnPropertyChanged(nameof(Address));
            }
        }
        public string Email
        {
            get { return model.Email; }
            set
            {
                model.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }
        public string IsCSharp
        {
            get { return model.IsCSharp; }
            set
            {
                if (Check1)
                    model.IsCSharp = "Да";
                else
                    model.IsCSharp = "Нет";
                OnPropertyChanged(nameof(IsCSharp));
            }
        }

        public string IsEnglish
        {
            get { return model.IsEnglish; }
            set
            {
                if (Check2)
                    model.IsEnglish = "Да";
                else
                    model.IsEnglish = "Нет";
                OnPropertyChanged(nameof(IsEnglish));
            }
        }

        public string IsSpain
        {
            get { return model.IsSpain; }
            set
            {
                if (Check3)
                    model.IsSpain = "Да";
                else
                    model.IsSpain = "Нет";
                OnPropertyChanged(nameof(IsSpain));
            }
        }
        public string IsOop
        {
            get { return model.IsSpain; }
            set
            {
                if (Check4)
                    model.IsOop = "Да";
                else
                    model.IsOop = "Нет";
                OnPropertyChanged(nameof(IsOop));
            }
        }

        public string IsBd
        {
            get { return model.IsBd; }
            set
            {
                if (Check5)
                    model.IsBd = "Да";
                else
                    model.IsBd = "Нет";
                OnPropertyChanged(nameof(IsBd));
            }
        }
        public PersonViewModel Clone()
        {
            var clonedViewModel = new PersonViewModel
            {
                Fullname = Fullname,
                Age = Age,
                Family = Family,
                Address = Address,
                Email = Email,
                Check1 = Check1,
                Check2 = Check2,
                Check3 = Check3,
                Check4 = Check4,
                Check5 = Check5
            };
            clonedViewModel.IsCSharp = Check1 ? "Да" : "Нет";
            clonedViewModel.IsEnglish = Check2 ? "Да" : "Нет";
            clonedViewModel.IsSpain = Check3 ? "Да" : "Нет";
            clonedViewModel.IsOop = Check4 ? "Да" : "Нет";
            clonedViewModel.IsBd = Check5 ? "Да" : "Нет";

            return clonedViewModel;
        }
        public string ComboText() { return Fullname + ", " + Age; }
        public bool IsEmpty()
        {
            return (string.IsNullOrEmpty(Fullname) || string.IsNullOrEmpty(Age) || string.IsNullOrEmpty(Family)
                || string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(Email));
        }
    }
}
