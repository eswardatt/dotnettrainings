using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtypes
{
   abstract class Emp
    {
        public void GetName(string name)
        {
            Console.WriteLine("Employee Name is {0} ", name);
        }

        public abstract void GetSalary(int hours,int amount);
    }
}
