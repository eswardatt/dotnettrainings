using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessspecifiers
{
    class Employee 
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.publicMethod();
            program.internalMethod();
            program.protectedInternalMethod();
        }
    }
}
