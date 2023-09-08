

namespace demoAppCallingInvoke
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Security.Cryptography;
    using System.Text;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine().ToString();
            Console.WriteLine("Enter password:");
            string password = Console.ReadLine().ToString();
            string key = $"{username},{password}";
            string encrptedKey = Encrypt(key);

            Console.WriteLine("Params loaded");
            List<Admin> adminsList=  ApICalling.GetAdmins(encrptedKey, "GetAdmins");
            Console.WriteLine("Name \t\t\t\t Email");
            foreach (var item in adminsList)
            {
                Console.WriteLine($"{item.Name} \t\t\t\t {item.Email}");
            }

        }

        private static string Encrypt(string clearText)
        {
            string encryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
    }
}
