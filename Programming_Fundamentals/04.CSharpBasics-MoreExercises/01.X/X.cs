using System;

namespace _01.X
{
    class X
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            var space = 0;
            var middleSpace = n - 2;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string(' ', space) + "x" + new string(' ', middleSpace) + "x");
                space++;
                middleSpace -= 2;
            }
            Console.WriteLine(new string(' ', space) + "x");

            for (int i = 0; i < n / 2; i++)
            {
                space--;
                middleSpace += 2;
                Console.WriteLine(new string(' ',space ) + "x" + new string(' ', middleSpace) + "x");
            }
        }
    }
}
