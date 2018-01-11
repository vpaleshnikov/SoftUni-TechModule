using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            var k = input.Count / 4;

            List<int> firstRow = input.Take(k).ToList();
            List<int> middleRow = input.Skip(k).Take(k * 2).ToList();
            List<int> lastRow = input.Skip(k).Skip(k * 2).Take(k).ToList();

            firstRow.Reverse();
            lastRow.Reverse();

            var concate = firstRow.Concat(lastRow).ToList();

            var result = new List<int>();

            for (int i = 0; i < middleRow.Count; i++)
            {
                result.Add(concate[i] + middleRow[i]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
