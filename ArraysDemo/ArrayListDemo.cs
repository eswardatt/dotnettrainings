using System;
using System.Collections;

namespace ArraysDemo
{
    class ArrayListDemo
    {
        
         
        static void Main_2()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add("string");
            arrayList.Add(true);
            arrayList.Add(10.20);
            arrayList.Add(20);
            
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");
            arrayList.Insert(1, "StringBuilder");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------");
            arrayList.RemoveAt(5);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            //
        }
    }
}
