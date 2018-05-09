using System;

namespace _08.SumOfOddNumbers
{
    public class SumOfOddNumbers
    {
        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 1; i <= count; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                    count++;
                }
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}