using System;

namespace _11.GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            var figureType = Console.ReadLine().ToLower();

            if (figureType == "triangle")
            {
                var area = TriangleArea();
                Console.WriteLine($"{area:F2}");
            }
            else if (figureType == "square")
            {
                var area = SquareArea();
                Console.WriteLine($"{area:F2}");
            }
            else if (figureType == "rectangle")
            {
                var area = RectangleArea();
                Console.WriteLine($"{area:F2}");
            }
            else if (figureType == "circle")
            {
                var area = CircleArea();
                Console.WriteLine($"{area:F2}");
            }
        }

        static double CircleArea()
        {
            var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        static double RectangleArea()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = width * height;
            return area;
        }

        static double SquareArea()
        {
            var side = double.Parse(Console.ReadLine());
            var area = side * side;
            return area;
        }

        static double TriangleArea()
        {
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var area = (side * height) / 2;
            return area;
        }
    }
}