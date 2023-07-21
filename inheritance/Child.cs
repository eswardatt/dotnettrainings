using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("Constructor from child class");
        }
        public void Test1fromChild()
        {
            Console.WriteLine("Test1 method from Child class");
        }

        public void Test2FromChild()
        {
            Console.WriteLine("Test2 method from Child class");
        }
    }
}
