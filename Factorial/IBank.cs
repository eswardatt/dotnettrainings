using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public abstract class Bank
    {
        public void GetBankName()
        {
            Console.WriteLine($"Bank name : SBI");
        }
        public abstract string GetAccountType();
    }

    public interface IBank
    {
        public void GetInterest();
        public void GetAccountType();
    }
}
