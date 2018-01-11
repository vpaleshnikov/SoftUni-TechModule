using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            string regex = @"\+359([- *])(2)(\1)(\d{3})(\1)(\d{4})\b";
            string phones = Console.ReadLine();

            var phoneMatches = Regex.Matches(phones, regex);

            var matchedPhones = phoneMatches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ",matchedPhones));
        }
    }
}
