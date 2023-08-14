namespace trycatchdemo
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //GetFullName("Eswar");

            //GetFullName("Eswar", "Datta");
            int dividend = 20;
            int diviser = 2;
            int qutient;
            int reminder;

            Divide(dividend, diviser, out qutient, out reminder);
            Console.WriteLine($"Quotient : {qutient}");
            Console.WriteLine($"Reminder : {reminder}");
        }
        // method types
        public static void GetFullName(string fname,string lastname="")
        {
            Console.WriteLine($"Full name is {fname} {lastname}");
        }

        static void Divide(in int dividend, in int divisor, out int quotient, out int reminder)
        {
            quotient = dividend / divisor;
            reminder = dividend % divisor;
        }
      public  static void Getage()
        {
            try
            {

                int[] intarray = new int[2];
                intarray[0] = 10;
                intarray[1] = 20;
                for (int i = 0; i < intarray.Length; i++)
                {
                    Console.WriteLine(intarray[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("final block");
            }
        }
    }
}