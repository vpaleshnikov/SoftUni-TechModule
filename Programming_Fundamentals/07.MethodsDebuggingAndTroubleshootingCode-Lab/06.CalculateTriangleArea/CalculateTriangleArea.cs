using System;
namespace _06.CalculateTriangleArea
{
    class CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            Console.WriteLine($"{GetTriangleArea(width, height)}");
        }
        static double GetTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
