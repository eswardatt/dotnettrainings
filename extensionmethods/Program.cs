using System;

namespace extensionmethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.GetStudentName();
            student.GetAddress();
            student.GetAddress(1,"str");
        }
    }
}
