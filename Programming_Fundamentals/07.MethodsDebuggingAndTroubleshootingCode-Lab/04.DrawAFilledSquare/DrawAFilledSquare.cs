using System;

namespace _04.DrawAFilledSquare
{
    class DrawAFilledSquare
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            PrintHeader(n);
            PrintMiddleRow(n);
            PrintHeader(n);
        }

        static void PrintMiddleRow(int n)
        {
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("-");
                for (int j = 1; j < n; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }

        static void PrintHeader(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
    }
}