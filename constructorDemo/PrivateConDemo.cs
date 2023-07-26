using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorDemo
{
    class PrivateConDemo
    {
        private PrivateConDemo()
        {

        }

        private static PrivateConDemo PrivateCon = null;

        public static PrivateConDemo GetInstance()
        {
            if (PrivateCon==null)
            {
                PrivateCon = new PrivateConDemo();
            }
            return PrivateCon;
        }

        public void Get()
        {
            Console.WriteLine("Method from Private constructor class");
        }
       
    }

    //PrivateConDemo obj
    //PrivateConDemo obj_1
    //PrivateConDemo obj_2
}
