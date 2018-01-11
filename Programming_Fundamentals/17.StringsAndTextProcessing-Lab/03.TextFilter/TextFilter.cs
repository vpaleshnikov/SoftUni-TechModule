using System;
using System.Linq;

namespace _03.TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            var badWords = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var text = Console.ReadLine();

            foreach (var badWord in badWords)
            {
                if (text.Contains(badWord))
                {
                    text = text
                        .Replace(badWord, new string('*', badWord.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
