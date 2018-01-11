using System;

namespace _09.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            foreach (var character in input)
            {
                Console.WriteLine($"{character} -> {((int)character) - 97}");
            }
        }
    }
}
