using System;
using System.Collections;
using System.Collections.Generic;

namespace Factorial
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string st = Reverse();
            Console.WriteLine(st);
            //// tightly coupled without factory
            //Console.WriteLine("Savings Account details");
            //IBank bank = new SavingsAccount();
            //bank.GetAccountType();
            //bank.GetInterest();
            //Console.WriteLine("---------------------------------");
            //IBank bank1 = new Current();
            //Console.WriteLine("Current Account details");
            //bank1.GetAccountType();
            //bank1.GetInterest();

            // Losly coupled with factory

            BankFactory bankFactory = new BankFactory();
            IBank bankFact = bankFactory.GetBankInstance(1);
            Console.WriteLine("Savings Account details");
            bankFact.GetAccountType();
        }

        static string Reverse()
        {
            string st = "eswar";
            char[] chararray = st.ToCharArray();
            string rst = "";
            for (int i = chararray.Length-1; i >= 0; i--)
            {
                rst += chararray[i];  
            }
            return rst;
        }
        static void Largest()
        {

            int[] persons = new int[6] { 10, 4, 8, 2, 1, 7 };
            int largenumber = persons[0];

            for (int i = 1; i < persons.Length; i++)
            {
                if (persons[i] < largenumber)
                {
                    largenumber = persons[i];
                }
            }
            Console.WriteLine(largenumber);

        }

        //"eswar is a very good boy and he is very good in nature";

        static void Seperate()
        {
           // string st = "eswar is a very good boy and he is very good in nature";
            string st = "eswar is a very good boy and he is very good in nature";
            string [] starray = st.Split(' ');
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
           
            for (int i = 0; i < starray.Length; i++)
            {
                if (!keyValuePairs.ContainsKey(starray[i]))
                {
                    keyValuePairs.Add(starray[i], 1);
                }
                else
                {
                    int temp = keyValuePairs[starray[i]];
                    keyValuePairs[starray[i]] = temp+1;
                }

            }

            foreach (var item in keyValuePairs.Keys)
            {
                Console.WriteLine($"{item} : {keyValuePairs[item]}");
            }
        }


       static int BracketsCount()
        {
            int result = 0;
            string st = "((()))(((";
            char[] starray = st.ToCharArray();
            int c1 = 0;
            int c2 = 0;

            for (int i = 0; i < starray.Length; i++)
            {
                if (starray[i]=='(')
                {
                    c1++;
                }
                else if(starray[i]==')')
                {
                    c2++;
                }
            }
            if (c1>c2)
            {
                result = c1 - c2;
            }
            else
            {
                result = c2 - c1;
            }

            return result;
        }
    }
}
