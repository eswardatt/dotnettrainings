using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class HashTabledemo
    {
        static void Main_1()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Name", "Eswar");
            hashtable.Add("age", 28);
            hashtable.Add("Email", "eswar@gmail.com");


            hashtable.Add("id", 1);
            hashtable.Add("id", 1.2);

            Console.WriteLine(hashtable["Name"].GetHashCode());
            foreach (var item in hashtable.Keys)
            {
                Console.Write(item + " : " + hashtable[item] + "\n");
            }


            int number = 1234212;
            int n = 2;
            int num = 0;
            string st = number.ToString();
            char[] charArray = st.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                int x = Convert.ToInt32(charArray[i]);
                if (n == x )
                {
                    num++;
                }
            }
            Console.WriteLine(num);
        }
    }
}
