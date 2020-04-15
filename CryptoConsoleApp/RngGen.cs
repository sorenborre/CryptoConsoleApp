using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace CryptoConsoleApp
{
    class RngGen
    {

        public  void RNGCrypto()
        {
            var watch = new Stopwatch();
            watch.Start();
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] data = new byte[4];
                for (int i = 0; i < 5000; i++)
                {
                    rng.GetBytes(data);
                    int value = BitConverter.ToInt32(data, 0);
                    Console.WriteLine(value);
                }
            }
            watch.Stop();
            Console.WriteLine("time: " + watch.ElapsedMilliseconds + "ms");
        }

        public  void Random()
        {
            var watch = new Stopwatch();
            watch.Start();
            var rng = new Random(32);
            byte[] data = new byte[4];

            for (int i = 0; i < 5000; i++)
            {
                rng.NextBytes(data);
                int value = BitConverter.ToInt32(data, 0);
                Console.WriteLine("rand" + value);
            }
            watch.Stop();
            Console.WriteLine("time: " + watch.ElapsedMilliseconds + "ms");
        }
    }
}
