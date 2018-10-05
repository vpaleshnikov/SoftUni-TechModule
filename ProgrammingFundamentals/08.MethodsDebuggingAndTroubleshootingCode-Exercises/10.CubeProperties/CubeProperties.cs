using System;

namespace _10.CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine().ToLower();
            if (parameter == "face")
            {
                var face = CubeFace(number);
                Console.WriteLine($"{face:F2}");
            }
            else if (parameter == "space")
            {
                var space = CubeSpace(number);
                Console.WriteLine($"{space:F2}");
            }
            else if (parameter == "volume")
            {
                var volume = CubeVolume(number);
                Console.WriteLine($"{volume:F2}");
            }
            else if (parameter == "area")
            {
                var area = CubeArea(number);
                Console.WriteLine($"{area:F2}");
            }
        }

        static double CubeArea(double number)
        {
            double result = 6 * (number * number);
            return result;
        }

        static double CubeVolume(double number)
        {
            double result = number * number * number;
            return result;
        }

        static double CubeSpace(double number)
        {
            double result = Math.Sqrt(3 * number * number);
            return result;
        }

        static double CubeFace(double number)
        {
            double result = Math.Sqrt(2 * number * number);
            return result;
        }
    }
}