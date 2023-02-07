using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._02.Vector
{
    internal class Program
    {
        class Vector
        {
            int x, y, z;
            public Vector()
            {
                x = 0; y = 0; z = 0;
            }
            public Vector(int z)
            {
                this.z = z;
            }
            public Vector(int y, int z) : this(z)
            {
                this.y = y;
            }
            public Vector(int x, int y, int z) : this(y, z)
            {
                this.x = x;
            }
            public void Input()
            {
                Console.Write("Enter x: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Enter y: ");
                y = int.Parse(Console.ReadLine());
                Console.Write("Enter z: ");
                z = int.Parse(Console.ReadLine());
            }
            public override string ToString() => $"x = {x}\ny = {y}\nz = {z}";
            public int X { get => x; }
            public int Y { get => y; }
            public int Z { get => z; }
            public double GetLength() => Math.Sqrt(x^2 + y^2 + z^2);          //длина вектора
            public double GetAnhle_XZ() => Math.Atan2(x, z) * 180 / Math.PI;  //угол XZ
            public void Mult(int i)                                           //увеличение на скаляр
            {
                x *= i; y *= i; z *= i;
            }
            public void Div(int i)                                            //уменьшение на скаляр
            {
                x /= i; y /= i;z /= i;
            }
            public Vector AddVector(Vector v)                                //Сложение двух векторов
            {
                Vector a = new Vector();
                a.x = x + v.x;
                a.y = y + v.y;
                a.z = z + v.z;
                return a;
            }
            public Vector MinVector(Vector v)                                 //вычитание двух векторов
            {
                Vector a = new Vector();
                a.x = x - v.x;
                a.y = y - v.y;
                a.z = z - v.z;
                return a;
            }
            public Vector MultVector(Vector v)                               //умножение вдух векторов
            {
                Vector a = new Vector();
                a.x = x * v.x;
                a.y = y * v.y;
                a.z = z * v.z;
                return a;
            }
            public int Scalar_product(Vector v)                              //скалярное произведение двух векторов
            {
                return x*v.x+y*v.y+z*v.z;
            }
            public double GetAngle(Vector v)                                 //угол между векторами
            {
                return Scalar_product(v) / (GetLength() * v.GetLength());
            }
            public bool Equal(Vector v)                                      //равенство векторов
            {
                if(x == v.x && y == v.y && z == v.z)
                    return true;
                else return false;
            }
        }
        static void Main(string[] args)
        {
            Vector vec1 = new Vector();
            Console.WriteLine("Enter 1 vector.");
            vec1.Input();

            Vector vec2 = new Vector();
            Console.WriteLine("\nEnter 2 vector.");
            vec2.Input();

            Console.WriteLine($"\nLength of 1 vector: {vec1.GetLength()}");

            Vector vec3 = new Vector();
            vec3 = vec1.AddVector(vec2);
            Console.WriteLine($"\nSum of 1 and 2 vector:\n");
            vec3.ToString();

            if (vec1.Equals(vec2))
                Console.WriteLine("\nVectors ARE equals.");
            else
                Console.WriteLine("\nVectors are NOT equals.");
            Console.ReadKey();
        }
    }
}
