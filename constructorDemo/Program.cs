using System;

namespace constructorDemo
{
    class Program
    {
        Program()
        {

        }
        static void Main(string[] args)
        {
            // StaticConDemo con = new StaticConDemo();
            //con.Get();
            //CopyConDemo copyCon = new CopyConDemo("Kumar");
            //copyCon.GetName();

            //CopyConDemo copyCon_1 = new CopyConDemo(copyCon);
            //copyCon.GetFullName("Krishna");

            PrivateConDemo privateCon = PrivateConDemo.GetInstance();
            
            privateCon.Get();
        }
    }
}
