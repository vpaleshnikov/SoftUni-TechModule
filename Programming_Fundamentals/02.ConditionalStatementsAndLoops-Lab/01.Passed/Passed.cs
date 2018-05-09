using System;

namespace _01.Passed
{
    public class Passed
    {
        public static void Main()
        {
            var inputGrade = double.Parse(Console.ReadLine());

            if (inputGrade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
