using System;
using System.Collections.Generic;

namespace _03.AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var result = new Dictionary<string, int>();

            while (input != "stop")
            {
                var quantity = int.Parse(Console.ReadLine());
                if (result.ContainsKey(input))
                {
                    result[input] += quantity;
                }
                else
                {
                    result.Add(input, quantity);
                }

                input = Console.ReadLine();
            }

            foreach (var resource in result)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
