using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDemo
{
    class GenericCollectionsDemo
    {
        static void Main()
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add("Ajay");
            list.Add(10.3f);

            Console.WriteLine("Elements are ");
            foreach(int temp in list)
                Console.WriteLine(temp);

                






        }
    }
}
