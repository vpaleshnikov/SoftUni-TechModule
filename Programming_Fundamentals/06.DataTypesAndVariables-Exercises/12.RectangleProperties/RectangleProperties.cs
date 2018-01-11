using System;
namespace _12.RectangleProperties
{
    class RectangleProperties
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            Console.WriteLine((width + height) * 2);
            Console.WriteLine(width * height);
            Console.WriteLine(Math.Sqrt(width * width + height * height));
        }
    }
}
