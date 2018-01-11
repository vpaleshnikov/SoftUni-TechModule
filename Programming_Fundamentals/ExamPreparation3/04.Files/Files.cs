using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Files
{
    class Files
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var data = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                .Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                var root = input.First();
                var fileData = input.Last().Split(';');
                var extension = fileData[0];
                var size = long.Parse(fileData[1]);

                if (!data.ContainsKey(root))
                {
                    data.Add(root, new Dictionary<string, long>());
                    data[root].Add(extension, size);
                }
                else
                {
                    data[root][extension] = size;
                }       
            }

            var query = Console.ReadLine()
                .Split(new string[] { " in " }, StringSplitOptions.RemoveEmptyEntries);
            var queryExtension = query[0];
            var queryRoot = query[1];

            var found = false;

            var result = new Dictionary<string, long>();

            foreach (var root in data)
            {
                var r = root.Key;
                var extensionData = root.Value;

                foreach (var extension in extensionData)
                {
                    var extensionName = extension.Key;
                    var fileTokens = extension.Key.Split('.');
                    var extensionRoot = fileTokens.Last();
                    var extensionSize = extension.Value;

                    if (r.EndsWith(queryRoot) && extensionRoot.EndsWith(queryExtension))
                    {
                        found = true;
                        result.Add(extensionName, extensionSize);
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var item in result.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
                {
                    Console.WriteLine($"{item.Key} - {item.Value} KB");
                }
            }
        }
    }
}
