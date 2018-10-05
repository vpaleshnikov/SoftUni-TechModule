using System;

namespace _09.MultiplicationTable
{
    public class MultiplicationTable
    {
        public static void Main()
        {
            var numberInput = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum = i * numberInput;
                var result = $"{numberInput} X {i} = {sum}";

                Console.WriteLine(result);
            }
        }
    }
}