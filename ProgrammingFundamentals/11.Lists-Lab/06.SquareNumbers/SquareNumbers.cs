using System;
using System.Linq;

namespace _06.SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            input = input.Where(n => Math.Sqrt(n) == (int)Math.Sqrt(n)).ToList();
            input.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
