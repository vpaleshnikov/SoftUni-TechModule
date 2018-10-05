using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.KeyReplacer
{
    class KeyReplacer
    {
        static void Main(string[] args)
        {
            var pattern = @"^(?<startKey>[a-zA-Z]*)(?:\<|\||\\)(?:.+)(?:\<|\||\\)(?<endKey>[a-zA-Z]*)$";

            var firstLine = Console.ReadLine();
            var text = Console.ReadLine();
            var keyMatch = Regex.Match(firstLine, pattern);

            if (keyMatch.Success)
            {
                var startKey = keyMatch.Groups["startKey"].Value;
                var endKey = keyMatch.Groups["endKey"].Value;
                var textPattern = $@"{startKey}(?<word>.*?){endKey}";

                var textMatch = Regex.Matches(text, textPattern);
                var result = new StringBuilder();

                foreach (Match matches in textMatch)
                {
                    result.Append(matches.Groups["word"].Value);
                }
                Console.WriteLine(result.ToString().Length == 0 ? "Empty result" : result.ToString());
            }
        }
    }
}