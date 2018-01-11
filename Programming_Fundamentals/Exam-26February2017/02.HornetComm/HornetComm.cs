//JUDJE -> 90/100

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.HornetComm
{
    class HornetComm
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var isPrivateMessage = false;
            var isBroadcast = false;

            var privateMessages = new Dictionary<string, List<string>>();
            var broadcasts = new Dictionary<string, string>();

            while (input != "Hornet is Green")
            {
                var inputTokens = input
                    .Split(new[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);

                if (inputTokens.Length != 2)
                {
                    continue;
                }

                var firstQuery = inputTokens[0];
                var secondQuery = inputTokens[1];

                if (firstQuery.All(char.IsDigit) && secondQuery.All(char.IsLetterOrDigit))
                {
                    isPrivateMessage = true;
                    var recipient = Reverse(firstQuery);
                    var message = secondQuery;
                    if (!privateMessages.ContainsKey(recipient))
                    {
                        privateMessages.Add(recipient, new List<string>());
                        privateMessages[recipient].Add(message);
                    }
                    else
                    {
                        privateMessages[recipient].Add(message);
                    }
                }
                else if (!firstQuery.All(char.IsDigit) && secondQuery.All(char.IsLetterOrDigit))
                {
                    isBroadcast = true;
                    var frequency = LettersCaseChanger(secondQuery);
                    var message = firstQuery;


                    if (!broadcasts.ContainsKey(frequency))
                    {
                        broadcasts.Add(frequency, message);
                    }
                    else
                    {
                        broadcasts[frequency] = message;
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if (isBroadcast)
            {
                foreach (var broadcast in broadcasts)
                {
                    Console.WriteLine($"{broadcast.Key} -> {broadcast.Value}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
            if (isPrivateMessage)
            {
                foreach (var privateMessage in privateMessages)
                {
                    foreach (var message in privateMessage.Value)
                    {
                        Console.WriteLine($"{privateMessage.Key} -> {message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
        public static string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
        public static string LettersCaseChanger(string text)
        {
            char[] cArray = text.ToCharArray();
            string result = string.Empty;
            for (int i = 0; i < cArray.Length; i++)
            {
                if (char.IsUpper(cArray[i]))
                {
                    result += char.ToLower(cArray[i]);
                }
                else if (char.IsLower(cArray[i]))
                {
                    result += char.ToUpper(cArray[i]);
                }
                else
                {
                    result += cArray[i];
                }
            }
            return result;
        }
    }
}