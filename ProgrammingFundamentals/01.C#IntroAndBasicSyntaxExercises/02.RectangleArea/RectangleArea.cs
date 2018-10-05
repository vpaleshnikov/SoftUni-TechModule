using System;

namespace _02.RectangleArea
{
    public class RectangleArea
    {
        public static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var rectangleArea = width * height;

            Console.WriteLine($"{rectangleArea:F2}");
        }
    }
}
