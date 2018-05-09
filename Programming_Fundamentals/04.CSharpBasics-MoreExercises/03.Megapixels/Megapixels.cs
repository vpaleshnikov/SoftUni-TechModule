using System;

namespace _03.Megapixels
{
   public class Megapixels
    {
        public static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var result = (width * height) / 1000000;

            Console.WriteLine($"{width}x{height} => {Math.Round(result,1)}MP");
        }
    }
}
