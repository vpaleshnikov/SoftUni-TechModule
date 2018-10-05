using System;
using System.Linq;

namespace _11.EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool isFountEqualSums = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int[] leftSide = numbers.Take(i).ToArray();
                int[] rightSide = numbers.Skip(i + 1).ToArray();
                
                if (leftSide.Sum() == rightSide.Sum())
                {
                    isFountEqualSums = true;
                    Console.WriteLine(i);
                    break;
                }
            }
            if (!isFountEqualSums)
            {
                Console.WriteLine("no");
            }
        }
    }
}
