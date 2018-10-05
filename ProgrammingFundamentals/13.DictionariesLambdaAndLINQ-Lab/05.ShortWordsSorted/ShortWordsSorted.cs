using System;
using System.Linq;

namespace _05.ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .ToLower()
                .Split(new char[] { '.'
                , ','
                , ':'
                , ';'
                , '('
                , ')'
                , '['
                , ']'
                , '\"'
                , '\''
                , '\\'
                , '/'
                , '!'
                , '?'
                , ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            input = input
                .Where(element => element.Length < 5)
                .OrderBy(a => a)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
