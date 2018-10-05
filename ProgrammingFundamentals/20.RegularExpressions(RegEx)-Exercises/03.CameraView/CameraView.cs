using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.CameraView
{
    class CameraView
    {
        static void Main(string[] args)
        {
            var indices = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var m = indices[0];
            var n = indices[1];

            var pattern = $"\\|\\<(.{{0,{m}}})(.{{0,{n}}})";

            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            Match match = regex.Match(input);

            List<string> result = new List<string>();

            while (input.Length > match.Index + 2 && match.Success)
            {
                string matchToAdd =
                    match.Groups[2].Value;

                if (matchToAdd.Contains("|"))
                {
                    matchToAdd = matchToAdd.Substring(0, matchToAdd.IndexOf("|"));
                }
                if (matchToAdd.Contains("<"))
                {
                    matchToAdd = matchToAdd.Substring(0, matchToAdd.IndexOf("<"));
                }

                result.Add(matchToAdd);
                input = input.Substring(match.Index + 2);
                match = regex.Match(input);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}