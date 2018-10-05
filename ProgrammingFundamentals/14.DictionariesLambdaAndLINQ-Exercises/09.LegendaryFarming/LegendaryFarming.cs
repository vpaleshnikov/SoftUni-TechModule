﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            var keyMaterials = new Dictionary<string, int>{["motes"] = 0, ["shards"] = 0, ["fragments"] = 0};
            var junkMaterials = new Dictionary<string, int>();
            var input = Console.ReadLine().ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                var materialQuantity = 0;
                var material = String.Empty;

                for (int i = 0; i < input.Count; i += 2)
                {
                    materialQuantity = int.Parse(input[i]);
                    material = input[i + 1];

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        keyMaterials[material] += materialQuantity;
                        if (keyMaterials[material] >= 250)
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials.Add(material, materialQuantity);
                        }
                        else
                        {
                            junkMaterials[material] += materialQuantity;
                        }
                    }
                }
                if (keyMaterials["shards"] >= 250
                    || keyMaterials["fragments"] >= 250
                    || keyMaterials["motes"] >= 250)
                {
                    if (keyMaterials["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                    }
                    else if (keyMaterials["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                    }
                    else
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                    }
                    keyMaterials[material] -= 250;
                    foreach (var item in keyMaterials.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }
                    foreach (var item in junkMaterials.OrderBy(a => a.Key))
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }
                    return;
                }
                input = Console.ReadLine().ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
        }
    }
}
