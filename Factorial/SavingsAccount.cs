using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class SavingsAccount : IBank
    {
        public void GetAccountType()
        {
            Console.WriteLine($"Account type : Savings");
        }

        public void GetInterest()
        {
            Console.WriteLine($"Intertest for savings account : 5%");
        }
    }
}
