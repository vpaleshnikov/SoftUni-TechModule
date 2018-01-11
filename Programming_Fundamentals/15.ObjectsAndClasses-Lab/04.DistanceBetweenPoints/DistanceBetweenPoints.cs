using System;
using System.Linq;

namespace _04.DistanceBetweenPoints
{
    class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

    }
    class DistanceBetweenPoints
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var point1 = new Point
            {
                X = input[0],
                Y = input[1]
            };
            input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var point2 = new Point
            {
                X = input[0],
                Y = input[1]
            };
            var distance = CalcDistance(point1, point2);

            Console.WriteLine($"{distance:F3}");
        }
        public static object CalcDistance(Point p1, Point p2)
        {
            var sideA = p1.X - p2.X;
            var sideB = p1.Y - p2.Y;

            return Math.Sqrt(sideA * sideA + sideB * sideB);
        }
    }
}
