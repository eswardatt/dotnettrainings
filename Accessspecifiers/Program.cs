using System;

namespace Accessspecifiers
{
   public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.privateMethod();
            program.internalMethod();
            program.protectedMethod();
            program.protectedInternalMethod();
            program.publicMethod();
        }

        private void privateMethod()
        {
            Console.WriteLine("Private Method");
        }

        internal void internalMethod()
        {
            Console.WriteLine("internal Method");
        }

        protected void protectedMethod()
        {
            Console.WriteLine("protected Method");
        }

        protected internal void protectedInternalMethod()
        {
            Console.WriteLine("protected-internal Method");
        }

        public void publicMethod()
        {
            Console.WriteLine("public Method");
        }
    }
}
