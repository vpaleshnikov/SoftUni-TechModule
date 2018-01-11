using System;

namespace _01.ChooseADrink
{
    class ChooseADrink
    {
        static void Main()
        {
            var profession = Console.ReadLine().ToLower();
            var drink = String.Empty;

            if (profession == "athlete")
            {
                drink = "Water";
            }
            else if (profession == "businessman" || profession == "businesswoman")
            {
                drink = "Coffee";
            }
            else if (profession == "softuni student")
            {
                drink = "Beer";
            }
            else
            {
                drink = "Tea";
            }
            Console.WriteLine(drink);
        }
    }
}
