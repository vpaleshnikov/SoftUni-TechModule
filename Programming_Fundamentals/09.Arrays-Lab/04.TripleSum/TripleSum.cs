using System;
using System.Linq;

namespace _04.TripleSum
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
            bool isTrue = false;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j <= numbers.Length - 1; j++)
                {
                    sum = numbers[i] + numbers[j];

                    if (numbers.Contains(sum))
                    {
                        isTrue = true;
                        Console.WriteLine($"{numbers[i]} + {numbers[j]} == {sum}");
                    }
                }
            }
            if (isTrue == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
