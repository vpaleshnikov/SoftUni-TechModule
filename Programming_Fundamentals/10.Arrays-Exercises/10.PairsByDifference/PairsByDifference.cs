using System;
using System.Linq;

namespace _10.PairsByDifference
{
    class PairsByDifference
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var difference = int.Parse(Console.ReadLine());
            var sum = 0;
            var count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    sum = numbers[i] - numbers[j];
                    if (sum == difference)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
