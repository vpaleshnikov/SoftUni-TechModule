using System;

namespace _09.ReversedChars
{
    class ReversedChars
    {
        static void Main(string[] args)
        {
            var a = char.Parse(Console.ReadLine());
            var b = char.Parse(Console.ReadLine());
            var c = char.Parse(Console.ReadLine());

            var oldA = c;
            var oldC = a;

            Console.WriteLine($"{oldA}{b}{oldC}");
        }
    }
}
