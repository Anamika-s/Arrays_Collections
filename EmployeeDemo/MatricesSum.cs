using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDemo
{
    class MatricesSum
    {
        static void Main()
        {
            int[,] mat1 = new int[3, 3] { { 1, 1, 1 }, { 2, 2, 2 }, { 3, 3, 3 } };

            int[,] mat2 = new int[3, 3] { { 2, 2, 1 }, { 2, 2, 2 }, { 3, 3, 3 } };
            int[,] sum = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum[i, j] = mat1[i, j] + mat2[i, j];
                }
            }
            Console.WriteLine("Elements of Mat1 ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(mat1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Elements of Mat2 ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(mat2[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Sum of both matrices is ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(sum[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}