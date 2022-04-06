using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDemo
{
    class Array2Demo
    {
        static void Main()
        {
            // 2 D Array
            //int[,] mat1 = new int[3, 3];
            //Console.WriteLine("Enter Elements");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        mat1[i, j] = Convert.ToByte(Console.ReadLine());
            //    }
            //}

            // Initialize 2-D Array

            int[,] mat1 = new int[,]
            {
                { 1,2,3 },
                { 3,4,2 },
                { 11,12,10 }
            };
            Console.WriteLine("Elements are");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(mat1[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
