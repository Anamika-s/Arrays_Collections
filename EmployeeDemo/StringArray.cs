using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDemo
{
    class StringArray
    {
        static void Main()
        {
            string[] names = new string[10];
            Console.WriteLine("Enter Names");
            for (int i = 0; i < 3; i++)
                names[i] = Console.ReadLine();
            Console.WriteLine("Names are ");
            foreach (string name in names)
                Console.WriteLine(name) ;





        }
    }
}
