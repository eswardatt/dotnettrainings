using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorDemo
{
    class ParameterCon
    {
        int i;
        public ParameterCon(int a)
        {
            i = a;
            Console.WriteLine("Parameterized constructor Called " + i);
        }
        public void Get()
        {
            Console.WriteLine("Parameterized constructor " + i);
        }
    }
}
