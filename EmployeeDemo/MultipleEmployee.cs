using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDemo
{
    class MultipleEmployee
    {
        static void Main()
        {
            Employee[] employees = new Employee[10];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter Details of Employee No {i+1}");
                employees[i] = new Employee();
                employees[i].GetDetails();
                employees[i].CalculateNetSalary();
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Details of Employee No {i + 1}");
                employees[i].DisplayDetails();
            }

            }

        }
}
