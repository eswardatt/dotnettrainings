using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class DictionaryDemo
    {
      
        static void Main11()
        {
            Dictionary<string, int> ageDictionary = new Dictionary<string, int>();
            //Adding values 
            ageDictionary["Ravi"] = 25;
            ageDictionary["Ram"] = 20;

            foreach (var item in ageDictionary)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
