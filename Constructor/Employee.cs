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
        public Employee(int x)
        {
           a = x;
        }

        public void Test()
        {
            Console.WriteLine(a);
        }


    }
}
