using System;
using System.Linq;

namespace _02.RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var random = new Random();
            
            for (int i = 0; i < input.Length - 1; i++)
            {
                var first = random.Next(0, input.Length);
                var second = random.Next(0, input.Length);

                var temp = input[first];
                input[first] = input[second];
                input[second] = temp;
                
            }
            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}