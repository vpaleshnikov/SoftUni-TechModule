using System;

namespace _12.TestNumbers
{
    class TestNumbers
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var maxSum = int.Parse(Console.ReadLine());

            var sum = 0;
            var countOfCombinations = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    countOfCombinations++;
                    sum += (i * j) * 3;
                    if (sum >= maxSum)
                    {
                        
                        break;
                    }
                }
                if (sum >= maxSum)
                {
                    break;
                }
            }
            if (sum >= maxSum)
            {
                Console.WriteLine(countOfCombinations + " combinations");
                Console.WriteLine($"Sum: {sum} >= {maxSum}");
            }
            else
            {
                Console.WriteLine(countOfCombinations + " combinations");
                Console.WriteLine("Sum: " + sum);
            }
        }
    }
}
