using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PopulationCounter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var data = new Dictionary<string, Dictionary<string, long>>();

            while (input != "report")
            {
                var inputTokens = input.Split('|').ToList();
                var country = inputTokens[1];
                var population = int.Parse(inputTokens[2]);
                var city = inputTokens[0];

                if (!data.ContainsKey(country))
                {
                    data.Add(country, new Dictionary<string, long>());

                    data[country].Add(city, population);
                }
                else
                {
                    data[country][city] = population;
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in data.OrderByDescending(a => a.Value.Values.Sum()))
            {
                var country = kvp.Key;
                Console.WriteLine($"{country} (total population: {kvp.Value.Values.Sum()})");

                foreach (var datas in kvp.Value.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"=>{datas.Key}: {datas.Value}");
                }
            }
        }
    }
}
