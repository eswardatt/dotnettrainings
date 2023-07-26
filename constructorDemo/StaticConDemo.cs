using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorDemo
{
    class StaticConDemo
    {
        static StaticConDemo()
        {
            Console.WriteLine("Static constructor called");
        }
        public StaticConDemo()
        {
            Console.WriteLine("Non-Static constructor called");
        }

        public void Get()
        {
            Console.WriteLine("method from StaticConDemo");

        }

    }
}
