using System;

namespace _08.SumOfOddNumbers
{
    class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 1; i <= count * 2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
