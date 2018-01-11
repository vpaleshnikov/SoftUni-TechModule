using System;

namespace _07.ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            Console.WriteLine("Before:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            var oldA = b;
            var oldB = a;
            Console.WriteLine("After:");
            Console.WriteLine($"a = {oldA}");
            Console.WriteLine($"b = {oldB}");
        }
    }
}
