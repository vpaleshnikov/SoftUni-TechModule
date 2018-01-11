using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.UserLogs
{
    class UserLogs
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var dict = new SortedDictionary<string, Dictionary<string, int>>();

            while (input != "end")
            {
                var inputTokens = input.Split(' ').ToList();
                var IPdata = inputTokens[0].Split('=');
                var IPaddress = IPdata[1];

                var userData = inputTokens[2].Split('=');
                var userName = userData[1];

                var count = 1;

                if (!dict.ContainsKey(userName))
                {
                    dict.Add(userName, new Dictionary<string, int>());
                }
                if (!dict[userName].ContainsKey(IPaddress))
                {
                    dict[userName].Add(IPaddress, count);
                }
                else
                {
                    dict[userName][IPaddress]++;
                }
                input = Console.ReadLine();
            }

            foreach (var user in dict)
            {
                var name = user.Key;
                Console.WriteLine($"{name}: ");
                foreach (var data in dict[name])
                {
                    var ip = data.Key;
                    var count = data.Value;

                    if (data.Key != user.Value.Keys.Last())
                    {
                        Console.Write($"{ip} => {count}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{ip} => {count}.");
                    }
                }
            }
        }
    }
}
