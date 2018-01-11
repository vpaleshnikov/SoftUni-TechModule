using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var result = new Dictionary<int, int>();

            foreach (int value in numbers)
            {
                if (result.ContainsKey(value))
                {
                    result[value]++;
                }
                else
                {
                    result.Add(value, 1);
                }
            }

            int mostCommonValue = 0;
            int highestCount = 0;

            foreach (var pair in result)
            {
                if (pair.Value > highestCount)
                {
                    mostCommonValue = pair.Key;
                    highestCount = pair.Value;
                }
            }
            Console.WriteLine(string.Join(" ", mostCommonValue));
        }
    }
}
