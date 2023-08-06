using System;

namespace classtypes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PermanentEmployee permanent = new PermanentEmployee();
            permanent.GetName("Kumar");
            int perHours = 20;
            int amountperhour = 1000;
            permanent.GetSalary(perHours,amountperhour);

            ContractEmployee contract = new ContractEmployee();
            contract.GetName("Krishna");
            int contHours = 20;
            int amountperHourforCont = 700;
            contract.GetSalary(contHours, amountperHourforCont);

            Student student = new Student();
            student.GetName("Kumar");
            student.GetName("Kumar", "Krishna");
        }
    }
}
