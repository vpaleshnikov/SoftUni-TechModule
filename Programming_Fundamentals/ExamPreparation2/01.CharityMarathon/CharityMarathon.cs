using System;

namespace _01.CharityMarathon
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            var marathonDaysLenght = int.Parse(Console.ReadLine());
            var numberOfRunners = int.Parse(Console.ReadLine());
            var averageNumberOfLapsPerRunner = int.Parse(Console.ReadLine());
            var lenghtOfTrack = long.Parse(Console.ReadLine());
            var capacityOfTrack = int.Parse(Console.ReadLine());
            var moneyDonatedPerKm = double.Parse(Console.ReadLine());

            if (capacityOfTrack * marathonDaysLenght > numberOfRunners)
            {
                Console.WriteLine($"Money raised: {(((numberOfRunners * averageNumberOfLapsPerRunner * (lenghtOfTrack) / 1000) * moneyDonatedPerKm)):F2}");
            }
            else
            {
                numberOfRunners = capacityOfTrack * marathonDaysLenght;
                Console.WriteLine($"Money raised: {(((numberOfRunners * averageNumberOfLapsPerRunner * (lenghtOfTrack) / 1000) * moneyDonatedPerKm)):F2}");
            }
        }
    }
}
