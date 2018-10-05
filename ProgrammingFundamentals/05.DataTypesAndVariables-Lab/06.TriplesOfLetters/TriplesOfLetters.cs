using System;

namespace _06.TriplesOfLetters
{
    class TriplesOfLetters
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine()) - 1;

            for (char i = 'a'; i <= 'a' + number; i++)
            {
                for (char j = 'a'; j <= 'a' + number; j++)
                {
                    for (char k = 'a'; k <= 'a' + number; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
