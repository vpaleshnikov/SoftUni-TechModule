using System;
using System.Linq;

namespace _09.ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (input.Length == 1)
            {
                Console.WriteLine($"{{ {input[0]} }}");
            }
            else if (input.Length % 2 != 0)
            {
                Console.WriteLine($"{{ {input[input.Length / 2 - 1]} , {input[input.Length / 2]} , {input[input.Length / 2 + 1]} }}");
            }
            else
            {
                Console.WriteLine($"{{ {input[input.Length/2-1]} , {input[input.Length / 2]} }}");
            }
        }
    }
}
