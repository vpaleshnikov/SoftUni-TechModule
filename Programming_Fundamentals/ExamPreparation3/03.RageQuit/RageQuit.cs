using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.RageQuit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            string sequences = Console.ReadLine();
            string pattern = @"(\D+)(\d+)";

            StringBuilder result = new StringBuilder();

            foreach (Match m in Regex.Matches(sequences, pattern))
            {
                string word = m.Groups[1].Value.ToUpper();
                int count = int.Parse(m.Groups[2].Value);

                for (int i = 0; i < count; i++)
                {
                    result.Append(word);
                }
            }
            int uniqueChars = result.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {uniqueChars}");
            Console.WriteLine(result);
        }
    }
}
