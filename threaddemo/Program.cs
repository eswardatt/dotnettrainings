using System;
using System.Threading;

namespace threaddemo
{
    //public delegate void Del_1(int x);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread starts");
            ParameterizedThreadStart threadStart = new ParameterizedThreadStart(method1);
            Thread t1 = new Thread(threadStart);
            t1.Start(10);

            
            Thread paramThread = new Thread(() => method2(10));
            paramThread.Start();

            Console.WriteLine("Main method end");
        }


        static void method1(object x)
        {
            int a = Convert.ToInt32(x);
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"Method1 :  {i}");
                if (i == 5)
                {
                    Console.WriteLine("Method1 start sleeping");
                    Thread.Sleep(5000);
                    Console.WriteLine("Method1 stop sleeping");
                }
            }
        }

        static void method2(int a)
        {
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"Method2 :  {i}");
            }
        }

        static void method3()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Method3 :  {i}");
            }
        }
    }
}
