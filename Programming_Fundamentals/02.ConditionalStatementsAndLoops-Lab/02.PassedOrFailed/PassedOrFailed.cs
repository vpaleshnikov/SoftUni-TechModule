using System;

namespace _02.PassedOrFailed
{
    public class PassedOrFailed
    {
        public static void Main()
        {
            var inputGrade = double.Parse(Console.ReadLine());

            var passed = "Passed!";
            var failed = "Failed!";

            var isPassed = inputGrade >= 3.00 ? passed : failed;

            Console.WriteLine(isPassed);
        }
    }
}
