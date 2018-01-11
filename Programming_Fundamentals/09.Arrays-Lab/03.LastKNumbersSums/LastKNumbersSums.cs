using System;

namespace _03.LastKNumbersSums
{
    class LastKNumbersSums
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            var result = new long[n];
            result[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long sum = 0;

                for (int j = i - k; j <= i - 1; j++)
                {
                    if (j >= 0)
                    {
                        sum += result[j];
                    }
                }
                result[i] = sum;
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
