using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MinMaxSumAverage
{
    class MinMaxSumAverage
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var result = new List<int>();

            for (int i = 0; i < n; i++)
            {
                result.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Sum = " + string.Join(" ",result.Sum()));
            Console.WriteLine("Min = " + string.Join(" ", result.Min()));
            Console.WriteLine("Max = " + string.Join(" ", result.Max()));
            Console.WriteLine("Average = " + string.Join(" ", result.Average()));
        }
    }
}