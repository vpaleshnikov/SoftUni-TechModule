using System;

namespace _04.BeverageLabels
{
    public class BeverageLabels
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyContentPer100ml = double.Parse(Console.ReadLine());
            var sugarContentPer100ml = double.Parse(Console.ReadLine());

            var energyContentResult = energyContentPer100ml * volume / 100;
            var sugarContentResult = sugarContentPer100ml * volume / 100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energyContentResult}kcal, {sugarContentResult}g sugars");
        }
    }
}
