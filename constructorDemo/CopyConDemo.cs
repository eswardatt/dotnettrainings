using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorDemo
{
    class CopyConDemo
    {
        string name;
        public CopyConDemo(string eName)
        {
            name = eName;
        }

        public CopyConDemo(CopyConDemo obj)
        {
            name = obj.name;
        }

        public void GetName()
        {
            Console.WriteLine("Name is "+ name);
        }

        public void GetFullName(string Initialname)
        {
            Console.WriteLine("Full Name is " + Initialname + name);
        }
    }
}
