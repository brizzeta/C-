using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.ComponentModel.Design;
using System.Xml;
using Newtonsoft.Json;
using System.IO;
using Formatting = Newtonsoft.Json.Formatting;
using System.ComponentModel;

namespace _8._11_Gallery
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private User user;
        private Command? signIn, openReg;
        private Service Service;

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public LoginViewModel()
        {
            user = User.Example;
            Service = new Service();
        }

        public string Login
        {
            get { return user.Login; }
            set
            {
                user.Login = value;
                OnPropertyChanged(nameof(Login));
            }
        }

        public string Password
        {
            get { return user.Password; }
            set
            {
                user.Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public ICommand OpenRegCommand
        {
            get
            {
                if (openReg == null) openReg = new Command(exec => Open(), can => CanOpen());
                return openReg;
            }
        }

        private bool CanOpen()
        {
            return true;
        }

        private void Open()
        {
            Service.OpenRegistrationWindow();
        }

        public ICommand SignInCommand
        {
            get
            {
                if (signIn == null) signIn = new Command(exec => Sign(), can => CanSignIn());
                return signIn;
            }
        }

        private bool CanSignIn()
        {
            return Login != null;
        }

        private void Sign()
        {
            try
            {
                if (File.Exists("user.json"))
                {
                    string data = File.ReadAllText("user.json");
                    List<dynamic>? users = JsonConvert.DeserializeObject<List<dynamic>>(data);
                    var userAuthenticate = users?.FirstOrDefault(u => u.Login == Login && u.Password == Password);
                    if (userAuthenticate != null)
                    {
                        Service.OpenGalleryWindow();
                    }
                    else
                    {
                        MessageBox.Show("Неправильно введен логин или пароль!", "Gallery",
                            MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }

                if (user != null)
                {
                    Service.CloseWindow(Application.Current.Windows[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gallery");
            }
        }
    }
    public class RegistrationViewModel : INotifyPropertyChanged
    {
        private User users;
        private string? repeatPassword;
        private Command? registration, openSignIn;

        private Service Service;

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public RegistrationViewModel()
        {
            users = User.Example;
            Service = new Service();
        }

        public string? Login
        {
            get { return users.Login; }
            set
            {
                users.Login = value;
                OnPropertyChanged(nameof(Login));
            }
        }

        public string? Password
        {
            get { return users.Password; }
            set
            {
                users.Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public string? RepeatPassword
        {
            get { return repeatPassword; }
            set
            {
                repeatPassword = value;
                OnPropertyChanged(nameof(RepeatPassword));
            }
        }

        public ICommand OpenSignIn
        {
            get
            {
                if (openSignIn == null) openSignIn = new Command(null, can => CanOpen());
                return openSignIn;
            }
        }

        private bool CanOpen()
        {
            return true;
        }

        public ICommand RegistrationCommand
        {
            get
            {
                if (registration == null) registration = new Command(exec => Reg(), can => CanReg());
                return registration;
            }
        }

        private bool CanReg()
        {
            return Login != null && Password != string.Empty && Password == RepeatPassword;
        }

        private void Reg()
        {
            var data = new { Login, Password };
            try
            {
                if (File.Exists("user.json"))
                {
                    string currentData = File.ReadAllText("user.json");
                    List<dynamic>? currentUsers = JsonConvert.DeserializeObject<List<dynamic>>(currentData);
                    if (currentUsers.Any(u => u.Login == Login))
                    {
                        MessageBox.Show("Такой пользователь уже существует", "Gallery",
                            MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }
                    currentUsers.Add(data);
                    string newData = JsonConvert.SerializeObject(currentUsers, Formatting.Indented);
                    File.WriteAllText("user.json", newData);
                }
                else
                {
                    List<dynamic> users = new List<dynamic> { data };
                    string jsonData = JsonConvert.SerializeObject(users, Formatting.Indented);
                    File.WriteAllText("user.json", jsonData);
                }

                Service.CloseWindow(Application.Current.Windows[1]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gallery");
            }
        }
    }
}
