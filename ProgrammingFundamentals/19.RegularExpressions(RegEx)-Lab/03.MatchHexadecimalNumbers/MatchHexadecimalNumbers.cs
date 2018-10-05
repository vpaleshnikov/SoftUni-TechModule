using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.MatchHexadecimalNumbers
{
    class MatchHexadecimalNumbers
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";
            var input = Console.ReadLine();

            var matches = Regex.Matches(input, pattern);

            var matched = matches.Cast<Match>().Select(a => a.Value).ToArray();

            Console.WriteLine(string.Join(" ",matched));
        }
    }
}
