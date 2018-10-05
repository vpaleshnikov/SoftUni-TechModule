using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .ToLower()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var numbers = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (!numbers.ContainsKey(word))
                {
                    numbers[word] = 1;
                }
                else
                {
                    numbers[word]++;
                }
            }

            var result = new List<string>();

            foreach (var item in numbers)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
