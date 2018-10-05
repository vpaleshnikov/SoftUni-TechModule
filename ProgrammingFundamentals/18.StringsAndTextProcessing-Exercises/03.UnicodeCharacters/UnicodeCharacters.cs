using System;

namespace _03.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            foreach (var ch in input)
            {
                Console.Write($"\\u{(((int)ch).ToString("X4")).ToLower()}");
            }
            Console.WriteLine();
        }
    }
}
