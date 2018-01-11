using System;

namespace _08.CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            int numberOfIngridients = int.Parse(Console.ReadLine());
            var calories = 0;
            for (int i = 0; i < numberOfIngridients; i++)
            {
                var ingridients = Console.ReadLine().ToLower();
                if (ingridients == "cheese")
                {
                    calories += 500;
                }
                else if (ingridients == "tomato sauce")
                {
                    calories += 150;
                }
                else if (ingridients == "salami")
                {
                    calories += 600;
                }
                else if (ingridients == "pepper")
                {
                    calories += 50;
                }
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
