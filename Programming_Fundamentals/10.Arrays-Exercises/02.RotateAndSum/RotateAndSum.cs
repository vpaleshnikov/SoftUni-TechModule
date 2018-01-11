using System;
using System.Linq;

namespace _02.RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var k = int.Parse(Console.ReadLine());

            var sum = new int[input.Length];

            for (int i = 0; i < k; i++)
            {
                var rotated = RotateArray(input);

                for (int j = 0; j < input.Length; j++)
                {
                    sum[j] += rotated[j];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
        static int[] RotateArray(int[] input)
        {
            var lastElement = input[input.Length - 1];
            
            for (int i = input.Length - 1; i > 0; i--)
            {
                input[i] = input[i - 1];
            }
            input[0] = lastElement;

            return input;
        }
    }
}
