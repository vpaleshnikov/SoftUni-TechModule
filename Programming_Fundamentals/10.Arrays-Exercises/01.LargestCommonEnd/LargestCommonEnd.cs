using System;
using System.Linq;

namespace _01.LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().Split().ToArray();
            var second = Console.ReadLine().Split().ToArray();

            var counter = 0;

            var min = Math.Min(first.Length, second.Length);

            for (int i = 0; i < min; i++)
            {
                if (first[i] == second[i])
                {
                    counter++;
                } 
            }
            if (counter == 0)
            {
                first = first.Reverse().ToArray();
                second = second.Reverse().ToArray();
                for (int i = 0; i < min; i++)
                {
                    if (first[i] == second[i])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
