using System;

namespace _17.PrintPartOfASCIITable
{
    class PrintPartOfASCIITable
    {
        static void Main()
        {
            int firstInput = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());
            for (int i = firstInput; i <= secondInput; i++)
            {
                Console.Write($"{(char)i} ");
            }
            Console.WriteLine();
        }
    }
}