using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.PhonebookUpgrade
{
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var phonebook = new SortedDictionary<string, string>();

            while (input != "END")
            {
                var inputTokens = input.Split(' ').ToList();

                var command = inputTokens[0];

                if (command == "A")
                {
                    var name = inputTokens[1];
                    var phoneNumber = inputTokens[2];

                    phonebook[name] = phoneNumber;
                }
                else if (command == "S")
                {
                    var name = inputTokens[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine(name + " -> " + phonebook[name]);
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (command == "ListAll")
                {
                    foreach (var contact in phonebook)
                    {
                        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
