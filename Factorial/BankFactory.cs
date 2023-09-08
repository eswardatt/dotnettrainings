using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    // dependency injection
    // abstract factory
    // architectural
    class BankFactory
    {
        //
        public IBank GetBankInstance(int id)
        {
            IBank bank = null;
            if (id==1)
            {
                bank = new SavingsAccount();
            }
            else if (id==2)
            {
                bank = new Current();
            }
            else
            {
                bank = null;
            }

            return bank;
        }
    }
}
