using System;

namespace _09.CountTheIntegers
{
    public class CountTheIntegers
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var counter = 0;

            while (true)
            {
                if (int.TryParse(input, out var number)) { counter++; }

                else {  break; }

                input = Console.ReadLine();
            }
            Console.WriteLine(counter);
        }
    }
}