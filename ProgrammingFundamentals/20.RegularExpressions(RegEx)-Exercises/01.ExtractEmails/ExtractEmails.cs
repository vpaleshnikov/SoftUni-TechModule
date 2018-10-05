using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            var pattern = @"(?<=\s)[a-z0-9]+([.-]\w*)*@[a-z]+([.-]\w*)*(\.[a-z]+)";
            var text = Console.ReadLine();

            var matches = Regex.Matches(text, pattern);

            var matched = matches.Cast<Match>().Select(a => a.Value).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, matched));
        }
    }
}