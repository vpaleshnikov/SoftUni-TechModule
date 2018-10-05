using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.HornetArmada
{
    public class Legion
    {
        public long LastActivity { get; set; }

        public string Name { get; set; }

        public List<string> SoldierType { get; set; }

        public long SoldierCount { get; set; }

    }
    class HornetArmada
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var legions = new List<Legion>();
            var isInList = false;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { " = ", " -> ", ":" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach (var item in legions)
                {
                    if (item.Name == input[1])
                    {
                        isInList = true;

                        if (item.LastActivity < long.Parse(input[0]))
                        {
                            item.LastActivity = long.Parse(input[0]);
                        }


                        if (!item.SoldierType.Contains(input[2]))
                        {
                            item.SoldierType.Add(input[2]);
                            item.SoldierCount += long.Parse(input[3]);
                        }
                        else
                        {
                            item.SoldierCount += long.Parse(input[3]);
                        }
                    }
                }
                if (!isInList)
                {
                    var legion = new Legion();
                    legion.LastActivity = long.Parse(input[0]);
                    legion.Name = input[1];
                    legion.SoldierType = new List<string>();
                    legion.SoldierType.Add(input[2]);
                    legion.SoldierCount = long.Parse(input[3]);
                    

                    legions.Add(legion);
                }
                isInList = false;

            }

            var command = Console.ReadLine().Split('\\').ToArray();

            if (command.Length > 1)
            {
                var activity = int.Parse(command[0]);
                var soldierType = command[1];

                foreach (var item in legions.Where(l => l.LastActivity < activity).OrderByDescending(sc => sc.SoldierCount))
                {                 
                    if (item.SoldierType.Contains(soldierType))
                    {
                        Console.WriteLine($"{item.Name} -> {item.SoldierCount}");
                    }
                }
            }
            else
            {
                var soldierType = command[0];

                foreach (var item in legions.OrderByDescending(a => a.LastActivity))
                {
                    if (item.SoldierType.Contains(soldierType))
                    {
                        Console.WriteLine($"{item.LastActivity} : {item.Name}");
                    }
                }
            }
        }
    }
}
