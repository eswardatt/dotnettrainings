using System;
using System.Text;

namespace DataTypes
{
    class Program
    {
        
        static void Main(string[] args)
        {
            float money = 2000.90f;
            double salary = 150000.20;
            int age=20;
            bool isActive=true;
            string name="Krishna";
            //Program program = new Program();
            //Console.WriteLine("Age : {0}", program.age);
            //Console.WriteLine("money : {0}", money);
            //Console.WriteLine("salary : {0}", salary);
            //Console.WriteLine("name : {0}", program.name);
            //Console.WriteLine("isactive : {0}", program.isActive);

            StringBuilder sb = new StringBuilder();
            sb.Append(" Age : ");
            sb.Append(age);
            sb.Append("\n Salary : ");
            sb.Append(salary);
            sb.Append("\n Name : ");
            sb.Append(name);
            Console.WriteLine(sb.ToString());
        }
    }
}
