using System;

namespace _03.MilesToKilometers
{
    public class MilesToKilometers
    {
        public static void Main()
        {
            var inputMiles = double.Parse(Console.ReadLine());
            var mileMultiplier = 1.60934;

            var milesInKilometers = inputMiles * mileMultiplier;

            Console.WriteLine($"{milesInKilometers:F2}");
        }
    }
}