using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class DefaultDelegates
    {
        public string GetFullName(string fname,string lname)
        {
            return fname + " " + lname;
        }
        public void Division(int a, int b)
        {
            Console.WriteLine("Division of {0} & {1} : {2}", a, b, a / b);
        }

        public bool CheckGender(string gender)
        {
            bool genderType = false;
            if (gender=="male")
            {
                genderType = true;
            }
            return genderType;

        }

        static void Main()
        {
            DefaultDelegates defaultDelegates = new DefaultDelegates();

            Func<string, string, string> func = defaultDelegates.GetFullName;
            string name =  func.Invoke("Kumar", "Krishna");
            Console.WriteLine("name : {0}", name);

            Action<int, int> action = defaultDelegates.Division;
            action.Invoke(20, 10);

            Predicate<string> predicate = defaultDelegates.CheckGender;
            bool gender = predicate.Invoke("male");
            Console.WriteLine(gender);

        }
    }
}
