using System;
using System.Linq;

namespace _05.MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var first = input[0].Distinct().ToArray();
            var second = input[1].Distinct().ToArray();

            if (first.Length == second.Length)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
