using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDemo
{
    class SearchNumber
    {
        static void Main()
       {
            int[] num = new int[] { 1, 2, 3, 5, 6, 10, 23, 45, 67 };
            Console.WriteLine("Enter Number to search");
            int x = Convert.ToByte(Console.ReadLine());
            int flag = 0;
            foreach(int temp in num)
            {
                if(x == temp)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0) Console.WriteLine("No is not found");
            else
                Console.WriteLine("Num found");




        }
    }
}
