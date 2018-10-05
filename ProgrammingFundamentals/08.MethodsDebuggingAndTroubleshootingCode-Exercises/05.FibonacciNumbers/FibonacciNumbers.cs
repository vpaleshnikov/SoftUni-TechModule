using System;

namespace _05.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciNumber(number));
        }

        static long FibonacciNumber(int number)
        {
            int firstNumber = 0;
            int secondNumber = 1;

            for (int i = 0; i < number; i++)
            {
                int temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = temp + secondNumber;
            }
            return secondNumber;
        }
    }
}