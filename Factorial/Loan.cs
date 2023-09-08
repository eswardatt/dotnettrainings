using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Loan : IBank
    {
       
        public void GetInterest()
        {
            throw new NotImplementedException();
        }

        void IBank.GetAccountType()
        {
            throw new NotImplementedException();
        }
    }
}
