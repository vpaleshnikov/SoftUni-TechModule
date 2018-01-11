using System;

namespace _13.GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());

            var combinationCount = 0;
            int i = 0;
            int j = 0;
            var sum = 0;
            var isFound = false;

            for (i = m; i >= n; i--)
            {
                for (j = m; j >= n; j--)
                {
                    combinationCount++;
                    sum = i + j;
                    if (sum == magicNumber)
                    {
                        isFound = true;
                        break;
                    }
                }
                if (sum == magicNumber)
                {
                    break;
                }
            }
            if (isFound == true)
            {
                Console.WriteLine($"Number found! {i} + {j} = {sum}");
            }
            else
            {
                Console.WriteLine($"{combinationCount} combinations - neither equals {magicNumber}");
            }
        }
    }
}
