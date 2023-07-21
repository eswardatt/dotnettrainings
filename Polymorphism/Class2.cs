using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Class2 : Class1
    {
        public void Test1(string a)
        {
            Console.WriteLine("Test1 {0} from string type", a);
        }

        public override void Test2(int a)
        {
            Console.WriteLine("Test2 from overide {0}", a);
        }
    }
}
