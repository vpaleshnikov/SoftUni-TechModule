using System;
using System.Linq;

namespace _03.HornetAssault
{
    class HornetAssault
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Length; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }
                var beehivesCount = beehives[i];
                beehives[i] -= hornets.Sum();

                if (beehivesCount >= hornets.Sum())
                {
                    hornets.RemoveAt(0);
                }
            }

            if (beehives.Any(b => b > 0))
            {
                Console.WriteLine(string.Join(" ", beehives.Where(b => b > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
