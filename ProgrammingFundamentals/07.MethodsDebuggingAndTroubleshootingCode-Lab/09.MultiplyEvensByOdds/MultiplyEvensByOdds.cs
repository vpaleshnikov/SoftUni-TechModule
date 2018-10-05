using System;

namespace _09.MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(MultiplyEvenAndOddNumbers(number));
        }

        static int MultiplyEvenAndOddNumbers(int number)
        {
            int sumOdd = GiveOddNumbers(number);
            int sumEven = GiveEvenNumbers(number);
            return sumOdd * sumEven;
        }

        static int GiveOddNumbers(int number)
        {
            var digit = 0;
            var oddResult = 0;
            while (number > 0)
            {
                digit = number % 10;
                if (digit % 2 != 0)
                {
                    oddResult += digit;
                }
                number = number / 10;
            }
            return oddResult;
        }

        static int GiveEvenNumbers(int number)
        {
            var digit = 0;
            var evenResult = 0;
            while (number > 0)
            {
                digit = number % 10;
                if (digit % 2 == 0)
                {
                    evenResult += digit;
                }
                number = number / 10;
            }
            return evenResult;
        }
    }
}