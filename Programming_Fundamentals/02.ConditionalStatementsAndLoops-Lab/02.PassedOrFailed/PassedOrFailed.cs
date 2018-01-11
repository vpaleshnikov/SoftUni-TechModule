using System;

namespace _02.PassedOrFailed
{
    class PassedOrFailed
    {
        static void Main()
        {
            if (double.Parse(Console.ReadLine()) >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
