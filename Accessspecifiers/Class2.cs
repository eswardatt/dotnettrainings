using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessspecifiers
{
    class Class2 : Program
    {
        static void Main(string[] args)
        {
            Class2 class2 = new Class2();
            class2.publicMethod();
            class2.protectedMethod();
            class2.internalMethod();
            class2.protectedInternalMethod();
        }

    }
}
