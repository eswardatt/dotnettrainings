using System;

namespace Constructor
{
    class Program
    {
        Program()
        {

        }
        static void Main(string[] args)
        {
            Employee employee = new Employee(10);
            // employee.b = 10;
            employee.Test();
            //Console.WriteLine(x);

        }
    }
}
