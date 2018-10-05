using System;

namespace _14.FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(TrailingZeroes(n));
        }
        static int TrailingZeroes(int n)
        {
            int sum = 0;

            for (int i = n / 5; i > 0; i /= 5) sum += i;

            return sum;
        }
    }
}
