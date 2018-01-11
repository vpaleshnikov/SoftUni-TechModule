using System;
using System.Linq;

namespace _04.Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            input = input.OrderByDescending(n => n).ToList();

            Console.WriteLine(string.Join(" ", input.Take(3)));
        }
    }
}
