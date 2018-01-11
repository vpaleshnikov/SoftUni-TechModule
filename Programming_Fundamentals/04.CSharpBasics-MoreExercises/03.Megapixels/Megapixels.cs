using System;

namespace _03.Megapixels
{
    class Megapixels
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var result = (width * height) / 1000000;

            Console.WriteLine($"{width}x{height} => {Math.Round(result,1)}MP");
        }
    }
}
