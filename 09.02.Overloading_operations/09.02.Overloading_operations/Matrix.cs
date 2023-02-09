using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_name
{
    class Matrix
    {
        int[,] matrix;
        public Matrix()
        {
            matrix = new int[5, 5];
            Random r = new Random();            

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    double d = r.NextDouble();
                    string num = d.ToString();
                    string n1 = num[num.Length - 1].ToString();

                    matrix[i, k] = int.Parse(n1);
                }
            }
        }
        public Matrix(int[,] matrix)
        {
            this.matrix = matrix;
        }
        public int this[int ind1, int ind2]
        {
            get => matrix[ind1, ind2];
            set => matrix[ind1, ind2] = value;
        }
        public void Print()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(0); k++)
                {
                    Console.Write(matrix[i, k] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static Matrix operator +(Matrix a, Matrix b) 
        {
            for(int i = 0; i < a.matrix.GetLength(0); i++)
            {
                for (int k = 0; k < a.matrix.GetLength(1); k++)
                {
                    a.matrix[i, k] += b.matrix[i, k];
                }
            }
            return a;
        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            for (int i = 0; i < a.matrix.GetLength(0); i++)
            {
                for (int k = 0; k < a.matrix.GetLength(1); k++)
                {
                    a.matrix[i, k] -= b.matrix[i, k];
                }
            }
            return a;
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
            for (int i = 0; i < a.matrix.GetLength(0); i++)
            {
                for (int k = 0; k < a.matrix.GetLength(1); k++)
                {
                    a.matrix[i, k] *= b.matrix[i, k];
                }
            }
            return a;
        }
        public static Matrix operator *(Matrix a, int b)
        {
            for (int i = 0; i < a.matrix.GetLength(0); i++)
            {
                for (int k = 0; k < a.matrix.GetLength(1); k++)
                {
                    a.matrix[i, k] *= b;
                }
            }
            return a;
        }
        public static bool operator ==(Matrix a, Matrix b)
        {
            return a.matrix == b.matrix;
        }
        public static bool operator !=(Matrix a, Matrix b)
        {
            return !(a == b);
        }
        public int GetLength(int param)
        {
            if (param == 0) return matrix.GetLength(0);
            else return matrix.GetLength(1);
        }
    }
}
