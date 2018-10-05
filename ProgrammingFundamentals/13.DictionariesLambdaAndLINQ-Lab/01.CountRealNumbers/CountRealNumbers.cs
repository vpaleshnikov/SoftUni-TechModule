using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            var result = new SortedDictionary<double, int>();
            
            foreach (var number in input)
            {
                if (!result.ContainsKey(number))
                {
                    result.Add(number, 1);
                }
                else
                {
                    result[number]++;
                }
            }

            foreach (var num in result)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
