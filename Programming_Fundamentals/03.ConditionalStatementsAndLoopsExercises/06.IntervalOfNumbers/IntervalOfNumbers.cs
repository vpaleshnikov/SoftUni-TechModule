using System;

namespace _06.IntervalOfNumbers
{
    class IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            var min = Math.Min(firstNumber, secondNumber);
            var max = Math.Max(firstNumber, secondNumber);

            for (int i = min; i <= max; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
