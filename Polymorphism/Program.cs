using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2 class2 = new Class2();
            class2.Test1();
            class2.Test1(1);
            class2.Test1("Kumar");
            Console.ReadLine();
        }
    }
}
