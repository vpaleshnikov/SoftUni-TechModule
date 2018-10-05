using System;

namespace _13.GameOfNumbers
{
    public class GameOfNumbers
    {
        public static void Main()
        {
            var firstNumberInput = int.Parse(Console.ReadLine());
            var secondNumberInput = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());

            var combinationsCount = 0;

            var firstIndex = 0;
            var secondIndex = 0;
            var sum = 0;
            var isFound = false;

            for (firstIndex = secondNumberInput; firstIndex >= firstNumberInput; firstIndex--)
            {
                for (secondIndex = secondNumberInput; secondIndex >= firstNumberInput; secondIndex--)
                {
                    combinationsCount++;
                    sum = firstIndex + secondIndex;

                    if (sum == magicNumber)
                    {
                        isFound = true;
                        Console.WriteLine($"Number found! {firstIndex} + {secondIndex} = {sum}");
                        return;
                    }
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"{combinationsCount} combinations - neither equals {magicNumber}");
            }
        }
    }
}