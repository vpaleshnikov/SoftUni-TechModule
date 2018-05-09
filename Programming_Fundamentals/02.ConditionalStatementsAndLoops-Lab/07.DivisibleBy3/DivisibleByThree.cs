using System;

namespace _07.DivisibleByThree
{
    public class DivisibleByThree
    {
        public static void Main()
        {
            for (int i = 3; i <= 100; i += 3)
            {
                if (i % 3 == 0) { Console.WriteLine(i); }
            }
        }
    }
}