using System;
using System.Collections.Generic;

namespace _04.FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var result = new Dictionary<string, string>();

            while (input != "stop")
            {
                var email = Console.ReadLine();

                if (email.EndsWith("us".ToLower()) || email.EndsWith("uk".ToLower()))
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (!result.ContainsKey(input))
                {
                    result.Add(input, email);
                }

                input = Console.ReadLine();
            }
            foreach (var data in result)
            {
                Console.WriteLine($"{data.Key} -> {data.Value}");
            }
        }
    }
}
