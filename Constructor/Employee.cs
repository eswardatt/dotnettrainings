using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Employee
    {
        int a;

        public int b;
        public Employee(int a)
        {
           this.a = a;
        }

        public void Test()
        {
            Console.WriteLine(a);
        }


    }
}
