using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var phonebook = new Dictionary<string, string>();

            while (input != "END")
            {
                var inputTokens = input.Split(' ').ToList();

                var command = inputTokens[0];
                var name = inputTokens[1];

                if (command == "A")
                {
                    var phoneNumber = inputTokens[2];

                    phonebook[name] = phoneNumber;
                }
                else if (command == "S")
                {
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine(name + " -> " + phonebook[name]);
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}