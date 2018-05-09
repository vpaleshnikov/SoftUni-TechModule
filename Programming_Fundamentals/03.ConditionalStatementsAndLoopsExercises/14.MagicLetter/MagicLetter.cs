using System;

namespace _14.MagicLetter
{
    public class MagicLetter
    {
        public static void Main()
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var secondLetter = char.Parse(Console.ReadLine());
            var magicLetter = char.Parse(Console.ReadLine());

            for (char firstIndex = firstLetter; firstIndex <= secondLetter; firstIndex++)
            {
                for (char secondIndex = firstLetter; secondIndex <= secondLetter; secondIndex++)
                {
                    for (char thirdIndex = firstLetter; thirdIndex <= secondLetter; thirdIndex++)
                    {
                        var indexIsEqualToMagicLetter = firstIndex == magicLetter 
                            || secondIndex == magicLetter 
                            || thirdIndex == magicLetter;

                        if (!indexIsEqualToMagicLetter)
                        {
                            Console.Write($"{firstIndex}{secondIndex}{thirdIndex} ");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}