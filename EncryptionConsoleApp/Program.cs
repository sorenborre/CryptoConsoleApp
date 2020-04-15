using System;

namespace EncryptionConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = 1;

            string encrypted = Encrypter.Encrypt("hola", key);
            Console.WriteLine(encrypted);

            string deCrypted = Encrypter.Decrypt(encrypted, key);
            Console.WriteLine(deCrypted);
        }
    }
}
