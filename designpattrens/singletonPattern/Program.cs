using System;
using System.Threading.Tasks;
using static singletonPattern.Normal;

namespace singletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Parallel.Invoke(
                ()=>GetTeacher(),
                ()=>GetStudent()
                );
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
