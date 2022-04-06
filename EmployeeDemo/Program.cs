using System;

namespace EmployeeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();


            //employee.GetDetails();
            //employee.CalculateNetSalary();

            //Console.WriteLine("Company Name is " + Employee.companyName);
            //Employee.DeptDetails();
            //Employee.ManagertDetails();

            //employee.DisplayDetails();

            Console.WriteLine("Company Name is"+ Employee.companyName);
            Employee.DeptDetails();
            Employee.ManagertDetails();

            Employee emp1 = new Employee();
            emp1.GetDetails();
            emp1.CalculateNetSalary();
            emp1.DisplayDetails();

            Employee emp2 = new Employee();
            emp2.GetDetails();
            emp2.CalculateNetSalary();
            emp2.DisplayDetails();

            Employee emp3= new Employee();
            emp3.GetDetails();
            emp3.CalculateNetSalary();
            emp3.DisplayDetails();






        }
    }
}
