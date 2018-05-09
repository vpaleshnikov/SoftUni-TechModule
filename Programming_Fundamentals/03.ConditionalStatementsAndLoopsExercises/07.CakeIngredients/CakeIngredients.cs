using System;

namespace _07.CakeIngredients
{
    public class CakeIngredients
    {
        public static void Main()
        {
            string ingridient;
            var ingridientCounter = 0;

            while ((ingridient = Console.ReadLine()) != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingridient}.");
                ingridientCounter++;
            }
            Console.WriteLine($"Preparing cake with {ingridientCounter} ingredients.");
        }
    }
}
