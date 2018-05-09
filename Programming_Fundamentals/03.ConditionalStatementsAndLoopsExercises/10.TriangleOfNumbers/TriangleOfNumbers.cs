﻿using System;

namespace _10.TriangleOfNumbers
{
    public class TriangleOfNumbers
    {
        public static void Main()
        {
            var countOfRows = int.Parse(Console.ReadLine());

            for (int row = 1; row <= countOfRows; row++)
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