using System;
using System.Numerics;

namespace _03.BigFactorial
{
    class BigFactorial
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            BigInteger number = new BigInteger();

            number = 1;

            for (int i = 1; i <= n; i++)
            {
                number = number * i;
            }
            Console.WriteLine(number);
        }
    }
}
