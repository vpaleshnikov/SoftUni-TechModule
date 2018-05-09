using System;

namespace _12.TestNumbers
{
    public class TestNumbers
    {
        public static void Main()
        {
            var firstNumberInput = int.Parse(Console.ReadLine());
            var secondNumberInput = int.Parse(Console.ReadLine());
            var maxSum = int.Parse(Console.ReadLine());

            var sum = 0;
            var countOfCombinations = 0;

            for (int firstIndex = firstNumberInput; firstIndex >= 1; firstIndex--)
            {
                for (int secondIndex = 1; secondIndex <= secondNumberInput; secondIndex++)
                {
                    countOfCombinations++;

                    sum += (firstIndex * secondIndex) * 3;

                    if (sum >= maxSum) { break; }
                }
                if (sum >= maxSum) { break; }
            }

            Console.WriteLine($"{countOfCombinations} combinations");

            if (sum >= maxSum) { Console.WriteLine($"Sum: {sum} >= {maxSum}"); }

            else { Console.WriteLine($"Sum: {sum}"); }
        }
    }
}