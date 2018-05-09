using System;

namespace _08.CaloriesCounter
{
    public class CaloriesCounter
    {
        public static void Main()
        {
            int numberOfIngridients = int.Parse(Console.ReadLine());

            var totalCalories = 0;

            for (int i = 0; i < numberOfIngridients; i++)
            {
                var ingridient = Console.ReadLine().ToLower();

                var ingridientIsCheese = ingridient == "cheese";
                var ingridientsIsTomatoSauce = ingridient == "tomato sauce";
                var ingridientIsSalami = ingridient == "salami";
                var ingridientIsPepper = ingridient == "pepper";

                if (ingridientIsCheese) { totalCalories += 500; }

                else if (ingridientsIsTomatoSauce) { totalCalories += 150; }

                else if (ingridientIsSalami) { totalCalories += 600; }

                else if (ingridientIsPepper) { totalCalories += 50; }
            }

            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}