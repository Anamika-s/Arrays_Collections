using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDemo
{
    class JaggedArray
    {static void Main()
        {
            // Declare Jagged Array
            int[][] marks = new int[10][];
            Console.WriteLine("Enter Mars for Student 1");
            marks[0] = new int[2];
            marks[0][0] = 10;
            marks[0][1] = 90;

            Console.WriteLine("Enter Mars for Student 2");
            marks[1] = new int[5];
            marks[1][0] = 10;
            marks[1][1] = 90;
            marks[1][2] = 10;
            marks[1][3] = 90;
            marks[1][4] = 10;
             
            for(int i=0;i<marks.Length;i++)
            {
                Console.WriteLine($"Marks of Student {i+1}");
                for(int j=0; j<marks[i].Length;j++)
                {
                    Console.Write(marks[i][j] + " ");
                } 
            }










        }
    }
}
