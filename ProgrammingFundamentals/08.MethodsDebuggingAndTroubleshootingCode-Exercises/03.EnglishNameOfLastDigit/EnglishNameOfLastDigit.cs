using System;

namespace _03.EnglishNameOfLastDigit
{
    class EnglishNameOfLastDigit
    {
        static void Main(string[] args)
        {
            var number = Math.Abs(long.Parse(Console.ReadLine()));
            Console.WriteLine(PrintTheEnglishNameOfTheDigit(number));
        }

        static string PrintTheEnglishNameOfTheDigit(long number)
        {
            var nameOfTheNumber = string.Empty;

            if (GetTheLastNumber(number) == 0)
            {
                nameOfTheNumber = "zero";
            }
            else if (GetTheLastNumber(number) == 1)
            {
                nameOfTheNumber = "one";
            }
            else if (GetTheLastNumber(number) == 2)
            {
                nameOfTheNumber = "two";
            }
            else if (GetTheLastNumber(number) == 3)
            {
                nameOfTheNumber = "three";
            }
            else if (GetTheLastNumber(number) == 4)
            {
                nameOfTheNumber = "four";
            }
            else if (GetTheLastNumber(number) == 5)
            {
                nameOfTheNumber = "five";
            }
            else if (GetTheLastNumber(number) == 6)
            {
                nameOfTheNumber = "six";
            }
            else if (GetTheLastNumber(number) == 7)
            {
                nameOfTheNumber = "seven";
            }
            else if (GetTheLastNumber(number) == 8)
            {
                nameOfTheNumber = "eight";
            }
            else if (GetTheLastNumber(number) == 9)
            {
                nameOfTheNumber = "nine";
            }
            return nameOfTheNumber;
        }

        static long GetTheLastNumber(long number)
        {
            return number % 10;
        }
    }
}