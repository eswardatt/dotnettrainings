using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classtypes
{
    class PermanentEmployee : Emp
    {
        public override void GetSalary(int hours, int amount)
        {
            double incentives = (10 * (amount * hours)) / 100;
            Console.WriteLine("Salary for permanent Employee {0}", incentives + (hours*amount));
        }

    }
}
