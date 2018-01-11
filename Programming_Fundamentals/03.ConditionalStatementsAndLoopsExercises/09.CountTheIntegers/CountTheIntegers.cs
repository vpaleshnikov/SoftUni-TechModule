using System;

namespace _09.CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var counter = 0;
            while (true)
            {
                int number;
                if (int.TryParse(input, out number))
                {
                    counter++;
                }
                else
                {
                    break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(counter);
        }
    }
}
