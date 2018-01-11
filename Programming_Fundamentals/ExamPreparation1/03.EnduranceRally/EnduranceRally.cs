using System;
using System.Linq;

namespace _03.EnduranceRally
{
    class EnduranceRally
    {
        static void Main(string[] args)
        {
            var drivers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var zones = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            var checkpoints = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            foreach (var driver in drivers)
            {
                double driverFuel = (int)driver[0];
                var zone = 0;

                for (int i = 0; i < zones.Length; i++)
                {
                    bool isFinished = true;

                    for (int j = 0; j < checkpoints.Length; j++)
                    {
                        if (i == checkpoints[j])
                        {
                            isFinished = false;
                            break;
                        }
                    }
                    if (isFinished)
                    {
                        driverFuel -= zones[i];
                    }
                    else
                    {
                        driverFuel += zones[i];
                    }

                    if (driverFuel > 0)
                    {
                        zone++;
                    }
                    else
                    {
                        Console.WriteLine($"{driver} - reached {zone}");
                        break;
                    }
                }
                if (driverFuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {driverFuel:f2}");
                }
            }            
        }
    }
}
