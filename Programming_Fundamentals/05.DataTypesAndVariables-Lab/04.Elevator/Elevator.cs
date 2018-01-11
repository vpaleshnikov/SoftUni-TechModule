using System;
namespace _04.Elevator
{
    class Elevator
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var p = int.Parse(Console.ReadLine());
            var courses = (int)Math.Ceiling((double)n / p);
            Console.WriteLine(courses);
        }
    }
}
