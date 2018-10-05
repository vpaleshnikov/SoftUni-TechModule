using System;
using System.Linq;

namespace _02.PokemonDontGo
{
    class PokemonDontGo
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            long result = 0;

            while (nums.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                long last = 0;

                if (index >= nums.Count)
                {
                    last = nums[nums.Count - 1];
                    nums[nums.Count - 1] = nums[0];
                }
                else if (index < 0)
                {
                    last = nums[0];
                    nums[0] = nums[nums.Count - 1];
                }
                else
                {
                    last = nums[index];
                    nums.RemoveAt(index);
                }


                for (int i = 0; i < nums.Count; i++)
                {
                    if (last >= nums[i])
                    {
                        nums[i] += last;
                    }
                    else
                    {
                        nums[i] -= last;
                    }
                }

                result += last;
            }

            Console.WriteLine(result);
        }
    }
}
