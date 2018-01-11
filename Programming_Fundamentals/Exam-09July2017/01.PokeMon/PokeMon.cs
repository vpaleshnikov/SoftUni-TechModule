using System;

namespace _01.PokeMon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var newN = n;
            var targets = 0;

            while (newN >= m)
            {
                newN -= m;

                targets++;
                if (newN == n * 0.5 && y > 0)
                {
                    newN /= y;
                }
            }
            Console.WriteLine(newN);
            Console.WriteLine(targets);
        }
    }
}
