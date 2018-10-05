using System;

namespace _02.MaxMethod
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int max = GetMax(first,second);
            int totalMax = GetMax(max, third);
            Console.WriteLine(totalMax);
        }

        static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }
    }
}
