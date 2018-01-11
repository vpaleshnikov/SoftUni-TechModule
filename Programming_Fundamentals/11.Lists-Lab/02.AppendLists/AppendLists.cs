using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { '|' },StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            input.Reverse();

            var splitted = new List<string>();
            var result = new List<string>();

            foreach (var item in input)
            {
                splitted = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(splitted);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
