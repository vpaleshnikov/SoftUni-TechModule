using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(new string[] { ","
                , ";"
                , ":"
                , "."
                , "!"
                , "("
                , ")"
                , "\""
                , "'"
                , "/"
                , "\\"
                , "["
                , "]"
                , " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var lowerCaseWords = new List<string>();
            var mixedCaseWords = new List<string>();
            var upperCaseWords = new List<string>();

            foreach (var word in words)
            {
                if (word.All(char.IsUpper))
                {
                    upperCaseWords.Add(word);
                }
                else if (word.All(char.IsLower))
                {
                    lowerCaseWords.Add(word);
                }
                else
                {
                    mixedCaseWords.Add(word);
                }
            }
            Console.WriteLine("Lower-case: " + string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: " + string.Join(", ",upperCaseWords));
        }
    }
}
