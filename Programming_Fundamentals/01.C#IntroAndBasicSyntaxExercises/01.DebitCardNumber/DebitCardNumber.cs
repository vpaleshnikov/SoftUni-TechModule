using System;

namespace _01.DebitCardNumber
{
    public class DebitCardNumber
    {
        public static void Main()
        {
            var firstInput = int.Parse(Console.ReadLine());
            var secondInput = int.Parse(Console.ReadLine());
            var thirdInput = int.Parse(Console.ReadLine());
            var fourthInput = int.Parse(Console.ReadLine());

            var result = $"{firstInput:D4} {secondInput:D4} {thirdInput:D4} {fourthInput:D4}";
            Console.WriteLine(result);
        }
    }
}
