using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtypes
{
    class ContractEmployee : Emp
    {
        public override void GetSalary(int hours, int amount)
        {
            double incentives = (5 * (amount * hours)) / 100;
            Console.WriteLine("Salary for permanent Employee {0}", incentives+(amount * hours));
        }
    }
}
