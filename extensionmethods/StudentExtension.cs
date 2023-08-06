using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extensionmethods
{
    static class StudentExtension
    {
        public static void GetAddress(this Student st, int i, string str)
        {
            Console.WriteLine("Address : From extension class");
        }
    }
}
