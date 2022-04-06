using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDemo
{
    class ArrayDemo
    {
        static void Main()
        {
            //int[] num = new int[10];
            //Console.WriteLine("ENter Numbers");
            //for (int i = 0; i < 10; i++)
            //    num[i] = Convert.ToByte(Console.ReadLine());
            // Initializing Array
            int[] num = new int[] { 1, 2, 3 };
            Console.WriteLine("Elements are");
            for (int i = 0; i < num.Length; i++)
                Console.WriteLine(num[i]);

           
            Console.WriteLine("Elemenst using forecach loop");
            foreach (int temp in num)
             Console.WriteLine(temp);

            // Sum & Average of the elements
            int sum = 0;
            foreach (int temp in num)
                sum = sum + temp;
            float avg = (float) sum / 10;
            Console.WriteLine($"Sum is {sum} Average is {avg}");

        }
    }
}
