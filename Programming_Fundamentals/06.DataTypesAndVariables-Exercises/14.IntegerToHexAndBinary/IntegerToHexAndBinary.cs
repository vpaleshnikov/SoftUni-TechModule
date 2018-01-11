using System;

namespace _14.IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(input, 16).ToUpper());
            Console.WriteLine(Convert.ToString(input, 2).ToUpper());
        }
    }
}