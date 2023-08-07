using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class HashTabledemo
    {
        static void Main()
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
                Console.Write(item +" : " + hashtable[item]+ "\n");
            }
            Console.WriteLine();
        }
    }
}
