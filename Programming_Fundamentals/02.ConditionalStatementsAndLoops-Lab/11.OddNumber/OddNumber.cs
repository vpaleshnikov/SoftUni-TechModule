using System;

namespace _11.OddNumber
{
    public class OddNumber
    {
        public static void Main()
        {
            var numberInput = int.Parse(Console.ReadLine());
            
            while (numberInput % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");
                numberInput = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The number is: {Math.Abs(numberInput)}");
        }
    }
}
