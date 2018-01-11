using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.LogsAggregator
{
    class LogsAggregator
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var data = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ')
                    .ToList();
                var IP = input[0];
                var user = input[1];
                var duration = int.Parse(input[2]);

                if (!data.ContainsKey(user))
                {
                    data.Add(user, new SortedDictionary<string, int>());
                    data[user].Add(IP, duration);
                }
                else
                {
                    if (!data[user].ContainsKey(IP))
                    {
                        data[user].Add(IP, duration);
                    }
                    else
                    {
                        data[user][IP] += duration;
                    }
                }
            }
            
            foreach (var user in data)
            {
                Console.Write($"{user.Key}: {user.Value.Values.Sum()} [");
                var userData = user.Value;

                foreach (var kvp in userData)
                {
                    var IP = kvp.Key;

                    if (IP != user.Value.Keys.Last())
                    {
                        Console.Write($"{IP}, ");
                    }
                    else
                    {
                        Console.Write($"{IP}");
                    }
                }
                Console.Write("]");
                Console.WriteLine();
            }
        }
    }
}