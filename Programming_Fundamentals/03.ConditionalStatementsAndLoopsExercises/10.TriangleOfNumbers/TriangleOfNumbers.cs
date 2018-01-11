using System;

namespace _10.TriangleOfNumbers
{
    class TriangleOfNumbers
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int row = 1; row <= number; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{row} ");
                }
                Console.WriteLine();
            }
        }
    }
}
