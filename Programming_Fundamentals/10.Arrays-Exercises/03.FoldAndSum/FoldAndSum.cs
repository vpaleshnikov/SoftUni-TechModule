using System;
using System.Linq;

namespace _03.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var k = numbers.Length / 4;

            int[] firstRow = new int[k];
            int[] secondRow = new int[k];
            int[] middleRow = new int[2 * k];

            //firstRow
            //var firstRow = numbers.Take(k).ToArray();
            for (int i = 0; i < firstRow.Length; i++)
            {
                firstRow[i] = numbers[k - 1 - i];
            }
            //secondRow
            //var lastRow = numbers.Skip(k * 3).Take(k).ToArray();
            for (int i = 0; i < secondRow.Length; i++)
            {
                secondRow[i] = numbers[numbers.Length - 1 - i];
            }

            //middleRow
            //var middleRow = numbers.Skip(k).Take(k * 2).ToArray();
            for (int i = 0; i < middleRow.Length; i++)
            {
                middleRow[i] = numbers[numbers.Length - k - 1 - i];
            }
            middleRow = middleRow.Reverse().ToArray();
            //Array.Reverse(firstRow);
            //Array.Reverse(lastRow);
            var concate = firstRow.Concat(secondRow).ToArray();
            var sum = new int[middleRow.Length];
            for (int i = 0; i < middleRow.Length; i++)
            {
                sum[i] = concate[i] + middleRow[i];
            }
            
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
