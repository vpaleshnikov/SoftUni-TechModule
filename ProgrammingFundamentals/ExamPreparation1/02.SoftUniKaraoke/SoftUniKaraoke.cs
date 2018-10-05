using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftUniKaraoke
{
    class SoftUniKaraoke
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            var availableSong = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            var awardedParticipants = new Dictionary<string, HashSet<string>>();

            var input = Console.ReadLine();

            var isAwarded = false;

            while (input != "dawn")
            {
                var inputTokens = input
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                var participant = inputTokens[0];
                var song = inputTokens[1];
                var awards = inputTokens[2];

                if (participants.Contains(participant) && availableSong.Contains(song))
                {
                    if (!awardedParticipants.ContainsKey(participant))
                    {
                        isAwarded = true;
                        awardedParticipants.Add(participant, new HashSet<string>());
                        awardedParticipants[participant].Add(awards);
                    }
                    else
                    {
                        awardedParticipants[participant].Add(awards);
                    }
                }

                input = Console.ReadLine();
            }
            if (isAwarded)
            {
                foreach (var participant in awardedParticipants
                    .OrderByDescending(a => a.Value.Count)
                    .ThenBy(a => a.Key))
                {
                    Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");
                    foreach (var awards in participant
                        .Value
                        .OrderBy(a => a))
                    {
                        Console.WriteLine($"--{awards}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }                      
        }
    }
}
