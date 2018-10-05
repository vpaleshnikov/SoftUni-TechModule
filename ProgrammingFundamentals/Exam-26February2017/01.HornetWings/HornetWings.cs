using System;

namespace _01.HornetWings
{
    class HornetWings
    {
        static void Main(string[] args)
        {
            var wingFlaps = int.Parse(Console.ReadLine());
            var distanceInMetersFor1000Flaps = double.Parse(Console.ReadLine());
            var endurane = int.Parse(Console.ReadLine());

            Console.WriteLine($"{(wingFlaps / 1000) * distanceInMetersFor1000Flaps:F2} m.");
            Console.WriteLine($"{(wingFlaps / 100) + (wingFlaps / endurane) * 5} s.");

        }
    }
}