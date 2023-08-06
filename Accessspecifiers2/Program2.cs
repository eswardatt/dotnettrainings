using Accessspecifiers;
using System;

namespace Accessspecifiers2
{
    class Program2 : Program
    {
        static void Main(string[] args)
        {
            Program2 program = new Program2();
            program.publicMethod();
            program.protectedInternalMethod();
            program.protectedMethod();
            Console.WriteLine("Hello World!");
        }
    }
}
