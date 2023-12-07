using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _25._10_Color
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class ViewModel : ViewModelBase
    {
        public ObservableCollection<ColorViewModel> colorList { get; set; }
        public int index { get; set; }
        private ColorViewModel color;
        private Commands add, remove;
        public ViewModel()
        {
            colorList = new ObservableCollection<ColorViewModel>();
            CurrentColor = new ColorViewModel();
        }
        public ColorViewModel CurrentColor
        {
            get { return color; }
            set
            {
                color = value;
                OnPropertyChanged(nameof(CurrentColor));
            }
        }
        public ICommand AddCommand
        {
            get
            {
                if (add == null)
                    add = new Commands(execute => Add(), can_exetue => CanAdd());
                return add;
            }
        }
        private void Add()
        {
            colorList.Add(CurrentColor.Clone());
        }

        private bool CanAdd()
        {
            if (colorList.Count == 0)
                return true;
            return !colorList.Any(x => x.Alpha == CurrentColor.Alpha && x.Red == CurrentColor.Red &&
            x.Green == CurrentColor.Green && x.Blue == CurrentColor.Blue);
        }
        public ICommand RemoveCommand
        {
            get
            {
                if (remove == null)
                    remove = new Commands(execute => Remove(), can_execute => CanRemove());
                return remove;
            }
        }
        private void Remove()
        {
            colorList.Remove(colorList[index]);
        }
        private bool CanRemove()
        {
            return index != -1;
        }
    }

    public class ColorViewModel : ViewModelBase
    {
        private Color color;
        private bool checkbox1, checkbox2, checkbox3, checkbox4;
        private byte alpha, red, green, blue;
        public bool Checkbox1
        {
            get
            {
                return checkbox1;
            }
            set
            {
                checkbox1 = value;
                OnPropertyChanged(nameof(Checkbox1));
            }
        }
        public bool Checkbox2
        {
            get
            {
                return checkbox2;
            }
            set
            {
                checkbox2 = value;
                OnPropertyChanged(nameof(Checkbox2));
            }
        }
        public bool Checkbox3
        {
            get
            {
                return checkbox3;
            }
            set
            {
                checkbox3 = value;
                OnPropertyChanged(nameof(Checkbox3));
            }
        }
        public bool Checkbox4
        {
            get
            {
                return checkbox4;
            }
            set
            {
                checkbox4 = value;
                OnPropertyChanged(nameof(Checkbox4));
            }
        }
        public byte Alpha
        {
            get
            {
                return alpha;
            }
            set
            {
                if (alpha != value)
                {
                    alpha = value;
                    OnPropertyChanged(nameof(Alpha));
                    SetColor();
                }
            }
        }
        public byte Red
        {
            get
            {
                return red;
            }
            set
            {
                if (red != value)
                {
                    red = value;
                    OnPropertyChanged(nameof(Red));
                    SetColor();
                }
            }
        }
        public byte Green
        {
            get
            {
                return green;
            }
            set
            {
                if (green != value)
                {
                    green = value;
                    OnPropertyChanged(nameof(Green));
                    SetColor();
                }
            }
        }
        public byte Blue
        {
            get
            {
                return blue;
            }
            set
            {
                if (blue != value)
                {
                    blue = value;
                    OnPropertyChanged(nameof(Blue));
                    SetColor();
                }
            }
        }
        public string Name
        {
            get
            {
                return color.name;
            }
            set
            {
                color.name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        private void SetColor()
        {
            if (color == null) color = new Color(" ");
            Name = System.Windows.Media.Color.FromArgb(Alpha, Red, Green, Blue).ToString();
        }
        public ColorViewModel Clone()
        {
            return new ColorViewModel { Alpha = Alpha, Red = Red, Green = Green, Blue = Blue };
        }
    }
}
