using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.ComponentModel;
using System.IO;

namespace _8._11_Gallery
{
    public class GalleryViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        ObservableCollection<ImagesViewModel> Images { get; set; } = new ObservableCollection<ImagesViewModel>();
        private ImagesViewModel? images;
        private int position = 0, maxImages;
        private Command nextImage, prevImage, firstImage, lastImage;
        public ImagesViewModel? Current_Image
        {
            get { return images; }
            set
            {
                if (images != value)
                {
                    images = value;
                    OnPropertyChanged(nameof(Current_Image));
                }
            }
        }
        public int Position
        {
            get { return position; }
            set
            {
                position = value;
                Current_Image = Images[Position];
                OnPropertyChanged(nameof(Position));
            }
        }
        public int MaxImages
        {
            get { return maxImages; }
            set
            {
                maxImages = value;
                OnPropertyChanged(nameof(MaxImages));
            }
        }
        public ICommand NextImageCommand
        {
            get
            {
                if (nextImage == null) nextImage = new Command(exec => Next(), can => CanNext());
                return nextImage;
            }
        }
        private bool CanNext()
        {
            return Position != MaxImages;
        }
        private void Next()
        {
            Position++;
        }
        public ICommand PreviousImageCommand
        {
            get
            {
                if (prevImage == null) prevImage = new Command(exec => Previous(), can => CanPrevious());
                return prevImage;
            }
        }
        private bool CanPrevious() { return Position > 0; }
        private void Previous() => Position--;
        public ICommand FirstImageCommand
        {
            get
            {
                if (firstImage == null) firstImage = new Command(exec => First(), can => CanFirst());
                return firstImage;
            }
        }
        private bool CanFirst() { return Position != 0; }
        private void First() => Position = 0;
        public ICommand LastImageCommand
        {
            get
            {
                if (lastImage == null) lastImage = new Command(exec => Last(), can => CanLast());
                return lastImage;
            }
        }
        private bool CanLast() { return Position != maxImages; }
        private void Last() => Position = MaxImages;
        public GalleryViewModel()
        {
            try
            {
                string jsonContent = File.ReadAllText("Images.json");
                List<ImageModel>? images = JsonConvert.DeserializeObject<List<ImageModel>>(jsonContent);
                if (images != null)
                {
                    foreach (var image in images)
                    {
                        Images.Add(new ImagesViewModel(image));
                    }
                    if (Images.Count > 0)
                    {
                        Position = 0;
                    }
                    maxImages = images.Count - 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gallery");
            }
        }
    }

    public class ImagesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ImageModel image;
        private double mark;

        public ImageModel Image
        {
            get { return image; }
        }

        public double Mark
        {
            get { return mark; }
            set
            {
                if (mark == value) return;
                mark = value;
                int index = image.Ratings.FindIndex(x => x.Key == User.Example.Login);
                if (index != -1)
                {
                    image.Ratings[index] = new KeyValue(User.Example.Login, mark);
                }
                else
                {
                    image.Ratings.Add(new KeyValue(User.Example.Login, mark));
                }
                OnPropertyChanged(nameof(Mark));
            }
        }

        public string Name
        {
            get { return image.Name; }
            set
            {
                image.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Date
        {
            get { return image.Date; }
            set
            {
                image.Date = value;
                OnPropertyChanged(nameof(Date));
            }
        }

        public string Author
        {
            get { return image.Author; }
            set
            {
                image.Author = value;
                OnPropertyChanged(nameof(Author));
            }
        }

        public string PathToPhoto
        {
            get
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Resources", "Images", Image.Path);
                return path;
            }
            set
            {
                image.Path = value;
                OnPropertyChanged(nameof(PathToPhoto));
            }
        }

        public string AverageRating
        {
            get
            {
                return (image.Ratings.Select(x => x.Value).Sum() / image.Ratings.Count).ToString();
            }
        }

        public string NumberOfRatings
        {
            get
            {
                return image.Ratings.Count.ToString();
            }
        }

        public ImagesViewModel(ImageModel image)
        {
            this.image = image;
            int index = image.Ratings.FindIndex(x => x.Key == User.Example.Login);
            if (index != -1)
            {
                Mark = image.Ratings[index].Value;
            }
            else
            {
                Mark = 0;
            }
        }
    }
}
