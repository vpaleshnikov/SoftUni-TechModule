using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.MatchNumbers
{
    class MatchNumbers
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var numbers = Console.ReadLine();

            var matches = Regex.Matches(numbers, pattern);

            var matched = matches.Cast<Match>().Select(a => a.Value).ToArray();

            Console.WriteLine(string.Join(" ", matched));
        }
    }
}
