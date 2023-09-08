using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Current : IBank
    {
        public void GetAccountType()
        {
            Console.WriteLine($"Account type : Current");
        }

        public void GetInterest()
        {
            Console.WriteLine($"Intertest for current account : 7%");
        }
    }
}
