using System;

namespace _02.CircleArea_Precision12
{
    class CircleArea_Precision12
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F12}",Math.PI * area * area);
        }
    }
}
