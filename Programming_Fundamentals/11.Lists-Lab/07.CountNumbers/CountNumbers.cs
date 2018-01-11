using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var result = new Dictionary<int, int>();

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

            result = result
                .OrderBy(a => a.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var counter in result)
            {
                Console.WriteLine(counter.Key + " -> " + counter.Value);
            }
        }
    }
}
