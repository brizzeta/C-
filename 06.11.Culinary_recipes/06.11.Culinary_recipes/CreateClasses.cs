using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._11.Culinary_recipes
{
    internal class CreateClasses
    {
        List<Class> classes;
        public CreateClasses()
        {
            classes = new List<Class>();

            Class first = new Class();
            Class second = new Class();
            Class third = new Class();
            Class fourth = new Class();
            Class fifth = new Class();
            Class sixth = new Class();
            Class seventh = new Class();
            Class eighth = new Class();
            Class ninth = new Class();
            Class tenth = new Class();

            first.Header = "ЛЕПЕШКИ С СУЛУГУНИ НА СКОВОРОДЕ";
            first.Paragraph1 = "Пшеничная мука\r\n320 \r\nгр\r\nКефир\r\n200 \r\nмл\r\nЯйца\r\n1 \r\nшт.\r\nРастительное масло\r\n2 \r\nстол.л.\r\nСулугуни\r\n200 \r\nгр\r\nРазрыхлитель\r\n1 \r\nчайн.л.\r\nСоль\r\n0.5 \r\nчайн.л.\r\n";
            first.Paragraph2 = "Как сделать лепешки с сыром сулугуни на кефире на сковороде? Подготовьте продукты. Кефир подойдет любой жирности, достаньте его из холодильника заранее — на теплой жидкости тесто замешивается лучше. Масло возьмите рафинированное, без запаха. Муки может уйти как больше, так и меньше указанного количества, будете смотреть по тесту.";
            first.Image = "../../../Resources/1.jpg";

            classes.Add(first);
        }
    }
}
