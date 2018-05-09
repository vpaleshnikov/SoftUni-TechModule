using System;

namespace _01.X
{
    public class X
    {
        public static void Main()
        {
            var height = int.Parse(Console.ReadLine());

            var space = 0;
            var middleSpace = height - 2;

            for (int i = 0; i < height / 2; i++)
            {
                Console.WriteLine(new string(' ', space) + "x" + new string(' ', middleSpace) + "x");
                space++;
                middleSpace -= 2;
            }
            Console.WriteLine(new string(' ', space) + "x");

            for (int i = 0; i < height / 2; i++)
            {
                space--;
                middleSpace += 2;
                Console.WriteLine(new string(' ', space) + "x" + new string(' ', middleSpace) + "x");
            }
        }
    }
}