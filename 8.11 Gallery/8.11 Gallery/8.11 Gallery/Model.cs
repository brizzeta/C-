using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._11_Gallery
{

    public class ImageModel
    {
        public string Name, Date, Author, Path;
        public List<KeyValue> Ratings;
        public ImageModel()
        {
            Name = Date = Author = Path = null;
            Ratings = new List<KeyValue>();
        }
    }

    public class User
    {
        private static User example;
        public string Login { get; set; }
        public string Password { get; set; }
        public static User Example
        {
            get
            {
                if (example == null) example = new User();
                return example;
            }
        }
        private User()
        {
            Login = Password = null;
        }
    }
}