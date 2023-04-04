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
            int plaintext = 50;
            int modulus = 97;
            int exponent = 2;
            int currExponent = 0;
            int accumulator = 1;
            int squareable = 1;
            int ciphertext;

            // https://en.wikipedia.org/wiki/Optimal_asymmetric_encryption_padding
            Console.WriteLine(Math.Pow(plaintext, exponent) % modulus);

            squareable = plaintext;

            do
            {
                currExponent = exponent & 1;
                if (currExponent > 0)
                {
                    accumulator = accumulator * squareable % modulus;
                }

                squareable = squareable * squareable % modulus;
                exponent = exponent >> 1;

            } while (exponent > 0);

            ciphertext = accumulator;
            Console.WriteLine(ciphertext);

        }
    }
}