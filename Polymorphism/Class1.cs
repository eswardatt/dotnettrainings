using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Class1
    {
        public void Test1()
        {
            Console.WriteLine("Test1");
        }
        public void Test1(int a)
        {
            Console.WriteLine("Test1 {0}",a);
        }

        public virtual void Test2(int a)
        {
            Console.WriteLine("Test2 {0}", a);
        }


    }
}
