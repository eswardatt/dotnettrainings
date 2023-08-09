using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class ListDemo
    {
      static  List<Student> students = new List<Student>();
        static void Main()
        {
            List<int> list = new List<int>();

            list.Add(10);
            list.Add(12);
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            //List<string> strList = new List<string>();
            //Add<string>("2", "2");
            //Add<int>(2, 2);

          
            Student student = new Student();
            student.Id = 1;
            student.Name = "Ravi";
            student.Email = "Ravi@gmail.com";

            Student student1 = new Student()
            {
                Id = 2,
                Name = "Kumar",
                Email = "Kumar@gmail.com"
            };

            Student student2 = new Student()
            {
                Id = 3,
                Name = "Raju",
                Email = "raju@gmail.com"
            };

            students.Add(student);
            students.Add(student1);
            students.Add(student2);

            Student obj = new Student();
            obj = GetStudentsById(3);

            Console.WriteLine(obj.Name);

            //foreach (var item in students)
            //{
            //   Console.WriteLine($"Id : {item.Id} \t Name : {item.Name} \t Email : {item.Email}");
            //  // Console.WriteLine("Id : {0} \t Name : {1} \t ")
            //}

            

         //   List<int,int> list_1 = new List<int,int>();

        }



       static void Add<T>(T a, T b)
        {
            Console.WriteLine(a +"\n"+ b);
        }

        static Student GetStudentsById(int id)
        {
            //List<Student> student = (from list in students
            //                        where list.Id == id
            //                        select list).ToList();


            List<Student> student = students.AsQueryable().Where(x => x.Id == id).ToList();


            

            Student student1 = new Student();
            if (student.Count>=1)
            {
                student1 = student[0];
            }
            

            //for (int i = 0; i < students.Count; i++)
            //{
            //    if (students[i].Id==id)
            //    {
            //        //Console.WriteLine($"{students[i].Id} {students[i].Name} {students[i].Email}");
            //        student1 = students[i];
            //        break;
            //    }
            //}
            return student1;
        }
    }
}
