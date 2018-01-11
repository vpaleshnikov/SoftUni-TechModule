using System;

namespace _02.ChooseADrink2
{
    class ChooseADrink2
    {
        static void Main()
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            var drink = String.Empty;
            var price = 0.00;

            if (profession == "Athlete")
            {
                drink = "Water";
                price = 0.70 * quantity;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                drink = "Coffee";
                price = 1.00 * quantity;
            }
            else if (profession == "SoftUni Student")
            {
                drink = "Beer";
                price = 1.70 * quantity;
            }
            else
            {
                drink = "Tea";
                price = 1.20 * quantity;
            }
            Console.WriteLine($"The {profession} has to pay {price:F2}.");
        }
    }
}
