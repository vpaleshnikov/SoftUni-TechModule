using System;

namespace _09.RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int total = 0;
            int sum = 0;
            bool isTrue = false;
            for (int i = 1; i <= number; i++)
            {
                sum = i;
                while (i > 0)
                {
                    total += i % 10;
                    i = i / 10;
                }
                isTrue = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine($"{sum} -> {isTrue}");
                total = 0;
                i = sum;
            }
        }
    }
}
