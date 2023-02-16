using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Struct_name
{
    struct Fraction          //операции с дробями
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public double Add(Fraction a)           //сложение
        {
            double num1 = Numerator / Denominator;
            double num2 = a.Numerator / a.Denominator;
            return num1 + num2;
        }
        public double Min(Fraction a)          //вычитание
        {
            double num1 = Numerator / Denominator;
            double num2 = a.Numerator / a.Denominator;
            return num1 - num2;
        }
        public double Mult(Fraction a)          //умножение
        {
            double num1 = Numerator / Denominator;
            double num2 = a.Numerator / a.Denominator;
            return num1 * num2;
        }
        public double Div(Fraction a)             //деление
        {
            double num1 = Numerator / Denominator;
            double num2 = a.Numerator / a.Denominator;
            return num1 / num2;
        }
    }
    struct Complex_num                 //операции над комплексными числами
    {
        public int A { get; set; }
        public int B { get; set; }
        public string Z { get; set; }
        public Complex_num(int a, int b) 
        {
            A = a;
            B = b;
            Z = a.ToString() + " + (" + b.ToString() + ")i";
        }
        public string Add(Complex_num a)                  //сложение
        {
            int num1 = A + a.A;
            int num2 = B + a.B;
            return Z = num1.ToString() + " + (" + num2.ToString() + ")i";
        }
        public string Min(Complex_num a)                  //вычитание
        {
            int num1 = A - a.A;
            int num2 = B - a.B;
            return Z = num1.ToString() + " + (" + num2.ToString() + ")i";
        }
        public string Mult(Complex_num a)                 //умножение
        {
            int num1 = A * a.A;
            int num2 = B * a.B;
            return Z = num1.ToString() + " + (" + num2.ToString() + ")i";
        }
        public string Div(Complex_num a)                //деление
        {
            int num1 = A / a.A;
            int num2 = B / a.B;
            return Z = num1.ToString() + " + (" + num2.ToString() + ")i";
        }
    }
    struct Birth                          //работа с датой рождения
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public Birth(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        public string Day_Week_Birth()                //нахождение дня недели по дате рождение
        {
            DateTime date = new DateTime(Year, Month, Day);
            return $"{date.DayOfWeek}";
        }
        public string Day_Week_Year(int year)            //нахождение дня недели по дате рождения в конкретный год
        {
            DateTime date = new DateTime(year, Month, Day);
            return $"{date.DayOfWeek}";
        }
    }

    //--------------         ДЗ          -----------------

    struct Vector                              //работа с вектором
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Vector(int z) : this()
        {
            Z = z;
        }
        public Vector(int y, int z) : this(z)
        {
            Y = y;
        }
        public Vector(int x, int y, int z) : this(y, z)
        {
            X = x;
        }
        public void Input()
        {
            Console.Write("Enter x: ");
            X = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            Y = int.Parse(Console.ReadLine());
            Console.Write("Enter z: ");
            Z = int.Parse(Console.ReadLine());
        }
        public override string ToString() => $"x = {X}\ny = {Y}\nz = {Z}";
        public double GetLength() => Math.Sqrt(X ^ 2 + Y ^ 2 + Z ^ 2);          //длина вектора
        public double GetAnhle_XZ() => Math.Atan2(X, Z) * 180 / Math.PI;  //угол XZ
        public void Mult(int i)                                           //увеличение на скаляр
        {
            X *= i; Y *= i; Z *= i;
        }
        public void Div(int i)                                            //уменьшение на скаляр
        {
            Z /= i; Y /= i; Z /= i;
        }
        public Vector AddVector(Vector v)                                //Сложение двух векторов
        {
            Vector a = new Vector();
            a.X = X + v.X;
            a.Y = Y + v.Y;
            a.Z = Z + v.Z;
            return a;
        }
        public Vector MinVector(Vector v)                                 //вычитание двух векторов
        {
            Vector a = new Vector();
            a.X = X - v.X;
            a.Y = Y - v.Y;
            a.Z = Z - v.Z;
            return a;
        }
        public Vector MultVector(Vector v)                               //умножение вдух векторов
        {
            Vector a = new Vector();
            a.X = X * v.X;
            a.Y = Y * v.Y;
            a.Z = Z * v.Z;
            return a;
        }
        public int Scalar_product(Vector v)                              //скалярное произведение двух векторов
        {
            return X * v.X + Y * v.Y + Z * v.Z;
        }
        public double GetAngle(Vector v)                                 //угол между векторами
        {
            return Scalar_product(v) / (GetLength() * v.GetLength());
        }
        public bool Equal(Vector v)                                      //равенство векторов
        {
            if (X == v.X && Y == v.Y && Z == v.Z)
                return true;
            else return false;
        }
    }
    struct Decimal_number                    //работа с системами счисления
    {
        public int Num { get; set; }
        public Decimal_number(int num) { Num = num; }
        public string ToBin() => Convert.ToString(Num, 2);    //перевод в двоичную
        public string ToHex() => Convert.ToString(Num, 8);    //перевод в восьмиричную
        public string ToOct() => Convert.ToString(Num, 16);   //перевод в шестнадцатиричную
    }
    public struct CMYK           //работа с CMYK
    {
        public int C { get; set; }
        public int M { get; set; }
        public int Y { get; set; }
        public int K { get; set; }
        public CMYK(int c, int m, int y, int k)
        {
            C = c;
            M = m;
            Y = y;
            K = k;
        }
        public override string ToString()
        {
            return $"{C}% {M}% {Y}% {K}%";
        }
    }
    struct RGB_Color             //работа с цветами
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public RGB_Color(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }
        public string ToHEX() => $"#{R.ToString("X2")}{G.ToString("X2")}{B.ToString("X2")}";  //перевод из RGD в HEX  
        private static double ClampCmyk(double value)   //если число rgb < 0
        {
            if (value < 0 || double.IsNaN(value))
                value = 0;
            return value;
        }
        public CMYK ToCMYK()        //перевод из RGD в CMYK
        {
            double rf = R / 255F;
            double gf = G / 255F;
            double bf = B / 255F;

            double k = ClampCmyk(1 - Math.Max(Math.Max(rf, gf), bf));
            double c = ClampCmyk((1 - rf - k) / (1 - k));
            double m = ClampCmyk((1 - gf - k) / (1 - k));
            double y = ClampCmyk((1 - bf - k) / (1 - k));

            k = Math.Round(k * 100);
            c = Math.Round(c * 100);
            m = Math.Round(m * 100);
            y = Math.Round(y * 100);

            return new CMYK((int)c, (int)m, (int)y, (int)k);
        }             
    }
}
