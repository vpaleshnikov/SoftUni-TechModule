using System;

namespace _06.IntervalOfNumbers
{
    public class IntervalOfNumbers
    {
        public static void Main(string[] args)
        {
            var firstInputNumber = int.Parse(Console.ReadLine());
            var secondInputNumber = int.Parse(Console.ReadLine());

            var start = Math.Min(firstInputNumber, secondInputNumber);
            var end = Math.Max(firstInputNumber, secondInputNumber);

            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
