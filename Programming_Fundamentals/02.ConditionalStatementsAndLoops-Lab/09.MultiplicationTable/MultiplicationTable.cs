using System;

namespace _09.MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum = i * number;
                Console.WriteLine($"{number} X {i} = {sum}");
            }
        }
    }
}
