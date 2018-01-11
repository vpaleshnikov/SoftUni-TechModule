using System;
using System.Linq;

namespace _07.SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            var firstArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var secondArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var max = Math.Max(firstArr.Length, secondArr.Length);
            int[] sum = new int[max];

            for (int position = 0; position <= max - 1; position++)
            {
                sum[position] = firstArr[position % firstArr.Length] + secondArr[position % secondArr.Length];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
