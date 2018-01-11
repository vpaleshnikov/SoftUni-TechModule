using System;

namespace _10.MultiplicationTable2
{
    class MultiplicationTable2
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var loops = int.Parse(Console.ReadLine());
            var sum = 0;

            if (loops > 10)
            {
                sum = number * loops;
                Console.WriteLine($"{number} X {loops} = {sum}");
            }
            else
            {
                for (int i = loops; i <= 10; i++)
                {
                    sum = i * number;
                    Console.WriteLine($"{number} X {i} = {sum}");
                }
            }
        }
    }
}
