using System;
using System.Linq;

namespace _05.RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number} => {Math.Round(number, 0, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
