using System;

namespace _02.ChooseADrink2
{
    public class ChooseADrink2
    {
        public static void Main()
        {
            var professionInput = Console.ReadLine().ToLower();
            var quantityInput = int.Parse(Console.ReadLine());

            var drink = String.Empty;
            var price = 0.00;

            var isAthlete = professionInput == "athlete";
            var isBusinessType = professionInput == "businessman" || professionInput == "businesswoman";
            var isSoftUniStudent = professionInput == "softuni student";

            if (isAthlete) { drink = "Water"; price = 0.70 * quantityInput; }

            else if (isBusinessType) { drink = "Coffee"; price = 1.00 * quantityInput; }

            else if (isSoftUniStudent) { drink = "Beer"; price = 1.70 * quantityInput; }

            else { drink = "Tea"; price = 1.20 * quantityInput; }
            
            Console.WriteLine($"The {professionInput} has to pay {price:F2}.");
        }
    }
}