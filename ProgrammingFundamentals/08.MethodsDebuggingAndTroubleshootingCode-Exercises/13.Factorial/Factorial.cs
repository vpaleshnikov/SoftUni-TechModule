using System;
using System.Numerics;

namespace _13.Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = number;
            for (int i = number; i > 1; i--)
            {
                BigInteger test = i - 1;
                factorial *= test;
            }
            Console.WriteLine((factorial));
        }
    }
}
