using System;

namespace _07.CakeIngredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var ingridientCounter = 0;
            while (input != "Bake!")
            {
                ingridientCounter++;
                Console.WriteLine($"Adding ingredient {input}.");

                input = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {ingridientCounter} ingredients.");
        }
    }
}
