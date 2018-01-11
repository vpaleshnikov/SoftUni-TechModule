using System;

namespace _12.NumberChecker
{
    class NumberChecker
    {
        static void Main()
        {
            var input = Console.ReadLine();
            int number;

            if (int.TryParse(input, out number))
            {
                Console.WriteLine("It is a number.");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
