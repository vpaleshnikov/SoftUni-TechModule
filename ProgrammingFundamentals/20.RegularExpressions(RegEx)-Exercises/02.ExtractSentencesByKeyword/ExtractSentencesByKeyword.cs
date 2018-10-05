using System;
using System.Text.RegularExpressions;

namespace _02.ExtractSentencesByKeyword
{
    class ExtractSentencesByKeyword
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();

            var sentences = text.Split(new[] { '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);

            var pattern = "\\b" + word + "\\b";

            Regex regex = new Regex(pattern);

            foreach (var sentence in sentences)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
