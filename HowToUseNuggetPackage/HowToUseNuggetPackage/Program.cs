using System;
using System.IO;
using NETCore.Encrypt;

namespace HowToUseNuggetPackage
{
    class Program
    {
        static void Main(string[] args)
        {
            const int KEY_INDEX = 0;
            const int IV_INDEX = 1;
            const string CONFIG_FILENAME = "SampleConfiguration.txt";

            var lines = File.ReadAllLines(CONFIG_FILENAME);
            //Console.WriteLine(string.Join(",", lines));

            var password = "myStrongP@$$W012|)";
            var encrypted = EncryptProvider.AESEncrypt(password, lines[KEY_INDEX], lines[IV_INDEX]);
            //Console.WriteLine($"Plain Password: {password}");
            //Console.WriteLine($"Encrypted password: {encrypted}");

            Console.WriteLine("Input password: ");
            var inputPassword = Console.ReadLine();
            var decrypted = EncryptProvider.AESDecrypt(encrypted, lines[KEY_INDEX], lines[IV_INDEX]);

            if(decrypted == inputPassword)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Failed");
            }


        }
    }
}
