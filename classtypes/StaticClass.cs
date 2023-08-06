using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtypes
{
    static class StaticClass
    {
       static int i = 0;

        public static void Get()
        {
            Console.WriteLine("Method from static class", i);
        }
    }
}
