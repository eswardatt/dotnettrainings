using System;

namespace ArraysDemo
{
    class Program
    {
        int age = 20;
        int age_1 = 25;

        static int[] array = new int[5];
        string[] stringarray = new string[5];
       // arra
        //0,1,2,3,4...9
        // array index starts from 0 and ends with arrayLength-1
        //
        // Not possible to extend
        // Not possible to Remove the particular value
        // Not [oosible to insert 


        static void Main_1(string[] args)
        {
            //array.
            array[0] = 20;
            array[1] = 25;
            array[2] = 27;
            array[3] = 28;
            array[4] = 29;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }

        }
    }
}
