using System;

namespace _12.NumberChecker
{
    public class NumberChecker
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var result = int.TryParse(input, out var number)
                ? "It is a number."
                : "Invalid input!";

            Console.WriteLine(result);
        }
    }
}
