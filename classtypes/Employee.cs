using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtypes
{
    class Employee
    {
       public static int tax = 10;
       public  double salary;

        const int age = 28;

        readonly string name = "Eswar";

        public Employee()
        {
            this.name = "Datta";
        }


        // static, non-static,readonly,constant(const)

        public void GetTax()
        {
            //age = 45;
            // name = "Datta";
            Console.WriteLine("Tax is : {0}", (salary * tax) / 100);
        }

        public static void Get()
        {
            //age = 45;
            // name = "Datta";
            Employee employee = new Employee();
            Console.WriteLine("Tax is : {0}", (employee.salary * tax) / 100);
        }

    }
}
