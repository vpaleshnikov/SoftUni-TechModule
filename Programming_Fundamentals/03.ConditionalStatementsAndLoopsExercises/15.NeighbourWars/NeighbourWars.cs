using System;

namespace _15.NeighbourWars
{
    public class NeighbourWars
    {
        public static void Main()
        {
            var peshoDamage = int.Parse(Console.ReadLine());
            var goshoDamage = int.Parse(Console.ReadLine());

            var peshoHealth = 100;
            var goshoHealth = 100;

            var round = 1;

            while (true)
            {
                //Gosho attaks
                if (round % 2 != 0)
                {
                    goshoHealth -= peshoDamage;

                    //Gosho is dead
                    if (goshoHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }
                //Pesho attacks
                else
                {
                    peshoHealth -= goshoDamage;

                    //Pesho is dead
                    if (peshoHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }

                //Third round players restore health with 10 points
                if (round % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }

                round++;
            }

            var result = Math.Max(peshoHealth, goshoHealth);

            var winner = result == peshoHealth ? "Pesho" : "Gosho";

            Console.WriteLine($"{winner} won in {round}th round.");
        }
    }
}
