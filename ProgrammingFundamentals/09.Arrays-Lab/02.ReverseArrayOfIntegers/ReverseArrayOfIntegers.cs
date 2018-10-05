﻿using System;
using System.Linq;

namespace _02.ReverseArrayOfIntegers
{
    class ReverseArrayOfIntegers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine(string.Join(" ", arr.Reverse()));
        }
    }
}
