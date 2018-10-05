using System;
using System.Linq;

namespace _03.SearchForANumber
{
    class SearchForANumber
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var manipulations = Console.ReadLine().Split().Select(int.Parse).ToArray();

            input = input.Take(manipulations[0]).ToList();

            var stop = manipulations[1];

            for (int i = 0; i < stop; i++)
            {
                input.Remove(input[i - i]);
            }

            if (input.Contains(manipulations[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
