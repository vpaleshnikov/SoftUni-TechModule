using System;

namespace _01.ChooseADrink
{
    public class ChooseADrink
    {
        public static void Main()
        {
            var professionInput = Console.ReadLine().ToLower();
            var drink = String.Empty;

            var isAthlete = professionInput == "athlete";
            var isBusinessType = professionInput == "businessman" || professionInput == "businesswoman";
            var isSoftUniStudent = professionInput == "softuni student";

            if (isAthlete) { drink = "Water"; }

            else if (isBusinessType) { drink = "Coffee"; }

            else if (isSoftUniStudent) { drink = "Beer"; }

            else { drink = "Tea"; }

            Console.WriteLine(drink);
        }
    }
}