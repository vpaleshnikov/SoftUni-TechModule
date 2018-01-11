using System;

namespace _02.CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var badWords = Console.ReadLine().ToLower();

            var counter = 0;
            var index = text.IndexOf(badWords);

            while (index != -1)
            {
                counter++;
                index = text.IndexOf(badWords, index+1);

            }
            Console.WriteLine(counter);
        }
    }
}
