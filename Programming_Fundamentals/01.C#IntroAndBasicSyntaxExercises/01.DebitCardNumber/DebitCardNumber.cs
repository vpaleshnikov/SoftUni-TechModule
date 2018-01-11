using System;

namespace _01.DebitCardNumber
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"" +
                $"{int.Parse(Console.ReadLine()):D4} " +
                $"{int.Parse(Console.ReadLine()):D4} " +
                $"{int.Parse(Console.ReadLine()):D4} " +
                $"{int.Parse(Console.ReadLine()):D4}");
        }
    }
}
