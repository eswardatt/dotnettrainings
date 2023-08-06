using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtypes
{
    class Student : Interfacedemo
    {
       public void GetName(string name)
        {
            Console.WriteLine("First Name is {0} ", name);
        }

      public  void GetName(string fname, string lName)
        {
            Console.WriteLine("Full Name is {0} {1} ", fname,lName);
        }
    }
}
