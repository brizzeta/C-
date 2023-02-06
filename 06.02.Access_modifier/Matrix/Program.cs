using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Program
    {
        class Matrix
        {
            int[,] matrix;
            public Matrix() 
            {
                matrix = new int[5,5];
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
            public void ToString()
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
            public int GetLength(int param)
            {
                if(param == 0) return matrix.GetLength(0);
                else return matrix.GetLength(1);
            }
        }        
        static void Main(string[] args)
        {
            Matrix m = new Matrix();

            Console.WriteLine("Enter matrix 5x5:");

            for(int i = 0; i < m.GetLength(0); i++)
            {
                for (int k = 0; k < m.GetLength(1); k++)
                {
                    m[i, k] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            m.ToString();
        }
    }
}
