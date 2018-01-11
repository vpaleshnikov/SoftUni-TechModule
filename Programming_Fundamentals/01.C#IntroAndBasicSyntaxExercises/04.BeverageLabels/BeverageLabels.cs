    using System;

    namespace _04.BeverageLabels
    {
        class BeverageLabels
        {
            static void Main(string[] args)
            {
                var name = Console.ReadLine();
                var volume = int.Parse(Console.ReadLine());
                var energyContent = double.Parse(Console.ReadLine()) * volume / 100;
                var sugarContent = double.Parse(Console.ReadLine()) * volume / 100;

                Console.WriteLine($"{volume}ml {name}:");
                Console.WriteLine($"{energyContent}kcal, {sugarContent}g sugars");
            }
        }
    }
