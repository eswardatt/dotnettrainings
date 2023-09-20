
namespace linqtocollections
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            CustomEmployee employee = new CustomEmployee();
            employee.FirstandFirstorDeafultExample();
            employee.SingleandSingleorDeafultExample();
            employee.LastandLastorDeafultExample();
            Console.ReadLine();
        }
    }
}
