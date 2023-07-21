using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
   public class Parent
    {
        public Parent()
        {
            Console.WriteLine("Constructor from parent class");
        }
        public void Test1()
        {
            Console.WriteLine("Test1 method from parent class");
        }

        public void Test2()
        {
            Console.WriteLine("Test2 method from parent class");
        }

        private void Test3()
        {
            Console.WriteLine("Test3 method from parent class");
        }
    }
}
