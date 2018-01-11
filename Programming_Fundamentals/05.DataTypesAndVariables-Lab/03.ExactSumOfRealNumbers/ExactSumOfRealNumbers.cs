using System;

namespace _03.ExactSumOfRealNumbers
{
    class ExactSumOfRealNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            decimal result = 0M;
            for (int i = 0; i < n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                result += number;
            }
            Console.WriteLine(result);
        }
    }
}
