using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.IO;
using System.Text.Json;
using System.Windows.Controls;
using System.Runtime.Versioning;
using Newtonsoft.Json;

namespace _30._10_Notebook2
{
    public class ViewModel : DependencyObject
    {
        private static readonly DependencyProperty PersonsProperty;
        private static readonly DependencyProperty SelectedPersonProperty;
        private static readonly DependencyProperty InformationFullNameProperty;
        private static readonly DependencyProperty InformationAddressProperty;
        private static readonly DependencyProperty InformationPhoneProperty;

        static ViewModel()
        {
            PersonsProperty = DependencyProperty.Register("Persons", typeof(ObservableCollection<Person>), typeof(ViewModel));
            SelectedPersonProperty = DependencyProperty.Register("SelectedPerson", typeof(Person), typeof(ViewModel));
            InformationFullNameProperty = DependencyProperty.Register("InformationFullName", typeof(string), typeof(ViewModel));
            InformationAddressProperty = DependencyProperty.Register("InformationAddress", typeof(string), typeof(ViewModel));
            InformationPhoneProperty = DependencyProperty.Register("InformationPhone", typeof(string), typeof(ViewModel));
        }

        public ObservableCollection<Person> Notebook
        {
            get { return (ObservableCollection<Person>)GetValue(PersonsProperty); }
            set { SetValue(PersonsProperty, value); }
        }

        public Person SelectedPerson
        {
            get { return (Person)GetValue(SelectedPersonProperty); }
            set { SetValue(SelectedPersonProperty, value); }
        }

        public string InformationFullName
        {
            get { return (string)GetValue(InformationFullNameProperty); }
            set { SetValue(InformationFullNameProperty, value); }
        }

        public string InformationAddress
        {
            get { return (string)GetValue(InformationAddressProperty); }
            set { SetValue(InformationAddressProperty, value); }
        }

        public string InformationPhone
        {
            get { return (string)GetValue(InformationPhoneProperty); }
            set { SetValue(InformationPhoneProperty, value); }
        }

        public ICommand AddCommand { get; private set; }
        public ICommand EditCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }
        public ICommand SaveJsonCommand { get; private set; }
        public ICommand LoadJsonCommand { get; private set; }

        public ViewModel()
        {
            Notebook = new ObservableCollection<Person>();
            AddCommand = new Commands(param => Add(), param => CanAdd());
            EditCommand = new Commands(param => Edit(), param => CanEdit());
            DeleteCommand = new Commands(param => Delete(), param => CanDelete());
            SaveJsonCommand = new Commands(param => SaveJson(), param => CanSaveJson());
            LoadJsonCommand = new Commands(param => LoadJson(), null);
        }

        private void Add()
        {
            Notebook.Add(new Person { FullName = InformationFullName, Address = InformationAddress, Phone = InformationPhone });
            InformationFullName = string.Empty;
            InformationAddress = string.Empty;
            InformationPhone = string.Empty;
        }

        private bool CanAdd()
        {
            return InformationFullName != string.Empty && InformationAddress != string.Empty && InformationPhone != string.Empty;
        }

        private void Edit()
        {
            if (SelectedPerson != null)
            {
                SelectedPerson.FullName = InformationFullName;
                SelectedPerson.Address = InformationAddress;
                SelectedPerson.Phone = InformationPhone;
                InformationFullName = string.Empty;
                InformationAddress = string.Empty;
                InformationPhone = string.Empty;
            }
        }

        private bool CanEdit()
        {
            return SelectedPerson != null && CanAdd();
        }

        private void Delete()
        {
            if (SelectedPerson != null)
            {
                Notebook.Remove(SelectedPerson);
                SelectedPerson = null;
            }
        }

        private bool CanDelete()
        {
            return SelectedPerson != null;
        }

        private void SaveJson()
        {
            try
            {
                string json = JsonConvert.SerializeObject(Notebook, Formatting.Indented);
                File.WriteAllText("Notebook.json", json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CanSaveJson()
        {
            return Notebook.Count > 0;
        }

        private void LoadJson()
        {
            try
            {
                if (File.Exists("Notebook.json"))
                {
                    string json = File.ReadAllText("Notebook.json");
                    ObservableCollection<Person> load = JsonConvert.DeserializeObject<ObservableCollection<Person>>(json);
                    Notebook.Clear();
                    foreach (var i in load)
                    {
                        Notebook.Add(i);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
