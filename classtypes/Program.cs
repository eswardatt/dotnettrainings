using System;

namespace classtypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.salary = 50000;
            employee.GetTax();

            Employee employee_1 = new Employee();
            employee_1.salary = 70000;
            //Employee.tax = 20;
            employee_1.GetTax();
        }
    }
}
