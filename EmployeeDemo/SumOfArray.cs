using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDemo
{
    class SumOfArray
    {
        static void Main()
        {
            int[] num = new int[10];

            Console.WriteLine("Enter Elmeent");
            int sum = 0;
            for (int i=0;i<10;i++)
            {
                num[i] = Convert.ToSByte(Console.ReadLine());
                if (num[i] < 0) continue;
                if (num[i] == 0) break;
                sum = sum + num[i];
            }
            Console.WriteLine($"Sum is {sum}");

            
        }
    }
}
