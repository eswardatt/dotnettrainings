using System;

namespace delegates
{
    public delegate void DelegateName(string name);
    public delegate void ArthimaticDelegate(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            DelegateName delegateName = new DelegateName(program.GetName);
            delegateName.Invoke("Eswar");

            ArthimaticDelegate arthimaticDelegate = new ArthimaticDelegate(program.Add);
            arthimaticDelegate += program.Mul;
            arthimaticDelegate.Invoke(10, 10);

            //program.Add(10, 10);
            //program.Mul(10, 10);

            DelegateName print = delegate (string name)
              {
                  Console.WriteLine("Anonymous {0}", name);
              };
            print("Datta");
            //Lamda expressions invented
            //Lamba expressions are short-hand techique to create anonymous methods
            DelegateName print_1 = (x) => { Console.WriteLine("Lamba expressions : {0}", x); };
            print_1("is short-hand technique of Anonumous methods");
        }

        public void GetName(string name)
        {
            Console.WriteLine("Name is : {0}",name);
        }

        public void Add(int a, int b)
        {
            Console.WriteLine("sum is : {0}", a+b);
        }

        public void Mul(int a, int b)
        {
            Console.WriteLine("multiply is : {0}", a * b);
        }

        //public void GetName(string name)
        //{
        //    Console.WriteLine(name);
        //}
    }
}
