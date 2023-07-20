using System;

namespace demo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // check a given number is prime or not 
           // int a = 7;
            Console.WriteLine("Enter number");
            int a =Convert.ToInt32( Console.ReadLine());
            
            int counter = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a%i==0)
                {
                    if (counter>2)
                    {
                        break;
                    }
                    else
                    {
                        counter++;
                    }
                    
                }
            }
            if (counter==2)
            {
                Console.WriteLine("{0} is prime", a);
            }
            else
            {
                Console.WriteLine("{0} is not a prime", a);
            }

            Console.ReadLine();
        }
    }
}
