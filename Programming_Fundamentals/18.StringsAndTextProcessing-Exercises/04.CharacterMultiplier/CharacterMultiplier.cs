using System;
using System.Linq;

namespace _04.CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            var string1 = input[0];
            var string2 = input[1];

            var sum = 0;

            var min = Math.Min(string1.Length, string2.Length);
            var max = Math.Max(string1.Length, string2.Length);

            for (int i = 0; i < min; i++)
            {
                sum += string1[i] * string2[i];
            }

            if (string1.Length != string2.Length)
            {
                string longerString = string1.Length > string2.Length ? longerString = string1 : longerString = string2;

                for (int i = min; i < max; i++)
                {
                    sum += longerString[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
