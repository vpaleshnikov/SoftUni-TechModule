using System;
using System.Text.RegularExpressions;

namespace _04.CubicMessages
{
    class CubicMessages
    {
        static void Main(string[] args)
        {
            var pattern = @"^(?<firstNumbers>\d+)(?<msg>[a-zA-Z]+)(?<secondNumebers>\d*[^a-zA-Z])*$";

            var input = Console.ReadLine();
            while (input != "Over!")
            {
                var matchLength = int.Parse(Console.ReadLine());
                var regex = new Regex(pattern);
                Match match = regex.Match(input);

                if (matchLength != match.Groups["msg"].Length)
                {
                    input = Console.ReadLine();
                    continue;
                }

                string result = string.Empty;
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsDigit(input[i]))
                    {
                        int index = input[i] - '0';
                        if (index >= match.Groups["msg"].Value.Length)
                        {
                            result += " ";
                        }
                        else
                        {
                            result += match.Groups["msg"].Value[index];
                        }
                    }
                }
                Console.WriteLine($"{match.Groups["msg"].Value} == {result}");

                input = Console.ReadLine();
            }
        }
    }
}