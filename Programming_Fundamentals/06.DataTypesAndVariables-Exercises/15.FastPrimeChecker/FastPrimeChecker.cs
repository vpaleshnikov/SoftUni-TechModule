using System;

namespace _15.FastPrimeChecker
{
    class FastPrimeChecker
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 2; i <= input; i++)
            {
                bool isTrue= true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isTrue = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {isTrue}");
            }
        }
    }
}