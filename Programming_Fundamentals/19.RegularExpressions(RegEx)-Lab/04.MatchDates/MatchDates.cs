using System;
using System.Text.RegularExpressions;

namespace _04.MatchDates
{
    class MatchDates
    {
        static void Main(string[] args)
        {
            var pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})(\1)(?<year>\d{4})\b";

            var dates = Console.ReadLine();

            var matches = Regex.Matches(dates, pattern);

            foreach (Match date in matches)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
