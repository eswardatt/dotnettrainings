using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singletonPattern
{
   
   sealed class Normal
    {
        public static int id = 0;
        private static readonly object obj = new object();

        private Normal()
        {
            id++;
            Console.WriteLine("Normal class {0}", id);
        }

        private static Normal instance = null;

        public static Normal GetInstance()
        {
            // double checked lock 
            if (instance == null)
            {
                lock (obj)
                {
                    if (instance == null)
                    {
                        instance = new Normal();
                    }
                }
            }
           
          
            return instance;
        }

        public void GetName(string name)
        {
            Console.WriteLine($"Name : {name}");
        }
      
      
        
    }
}
