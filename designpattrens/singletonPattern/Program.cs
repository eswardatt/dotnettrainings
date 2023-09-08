using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static singletonPattern.Normal;

namespace singletonPattern
{
    class Program
    {
      static  int age = 10;
        static void Main()
        {
            List<string> stringList = new List<string>
        {
            "apple", "banana", "apple", "orange", "banana", "apple"
        };

            var groupedCounts = stringList.GroupBy(str => str)
                                         .Select(group => new { Value = group.Key, Count = group.Count() });

            foreach (var group in groupedCounts)
            {
                Console.WriteLine($"Value: {group.Value}, Count: {group.Count}");
            }
        }
        // msi

        public void Get() {
            age = age+10;
            Console.WriteLine(age);
        }

        public void Get_1()
        {
            age = age+10;
            Console.WriteLine(age);
        }

        public static void GetTeacher()
        {
            Normal normal_1 = Normal.GetInstance();
            normal_1.GetName("Teacher");
        }

        public static void GetStudent()
        {
            Normal normal = Normal.GetInstance();
            normal.GetName("Student");
        }
    }
}
