using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionConsoleApp
{
    class Encrypter
    {
        public static string Encrypt(string word, int key)
        {
            string wordEncrypt = null;
            
            foreach (var c in word)
            {
                int i = c + key;
                char d = (char)i;
                wordEncrypt += d;
            }
            return wordEncrypt;
        }

        public static string Decrypt(string word, int key)
        {
            string wordDeEncrypt = null;

            foreach (var c in word)
            {
                int i = c - key;
                char d = (char)i;
                wordDeEncrypt += d;
            }
            return wordDeEncrypt;
        }
    }
}
