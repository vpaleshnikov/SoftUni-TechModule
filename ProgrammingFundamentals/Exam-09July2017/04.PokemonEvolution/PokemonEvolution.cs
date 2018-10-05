using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.PokemonEvolution
{
    public class Evolutions
    {
        public string EvolutionType { get; set; }

        public int EvolutionIndex { get; set; }

    }
    class PokemonEvolution
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var pokemonEvolutions = new Dictionary<string, List<Evolutions>>();

            while (input != "wubbalubbadubdub")
            {
                var inputTokens = input
                    .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                if (inputTokens.Length > 1)
                {
                    var name = inputTokens[0];
                    var type = inputTokens[1];
                    var index = int.Parse(inputTokens[2]);

                    var evoluiton = new Evolutions()
                    {
                        EvolutionType = type,
                        EvolutionIndex = index
                    };
                    if (!pokemonEvolutions.ContainsKey(name))
                    {
                        pokemonEvolutions.Add(name, new List<Evolutions>());
                        pokemonEvolutions[name].Add(evoluiton);
                    }
                    else
                    {
                        pokemonEvolutions[name].Add(evoluiton);
                    }
                }
                else
                {
                    foreach (var pokemon in pokemonEvolutions)
                    {
                        if (inputTokens[0] == pokemon.Key)
                        {
                            Console.WriteLine($"# {pokemon.Key}");
                            foreach (var evo in pokemon.Value)
                            {
                                Console.WriteLine($"{evo.EvolutionType} <-> {evo.EvolutionIndex}");
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var pokemon in pokemonEvolutions)
            {
                Console.WriteLine($"# {pokemon.Key}");
                foreach (var evo in pokemon.Value.OrderByDescending(a => a.EvolutionIndex))
                {
                    Console.WriteLine($"{evo.EvolutionType} <-> {evo.EvolutionIndex}");
                }
            }
        }
    }
}
