// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// innanzitutto occorre implementare fare quadrato modulare 

using System;

namespace HomomorphicRSA
{
    class RSACrypto
    {
        
        static void Main(string[] args)
        {
            int message = 50;
            int modulus = 97;

            Console.WriteLine(message*message%modulus);
        }
    }
}