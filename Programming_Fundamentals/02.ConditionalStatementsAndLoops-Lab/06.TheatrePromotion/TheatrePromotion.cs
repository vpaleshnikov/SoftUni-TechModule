using System;

namespace _06.TheatrePromotion
{
    public class TheatrePromotion
    {
        public static void Main()
        {
            var dayInput = Console.ReadLine().ToLower();
            var ageInput = int.Parse(Console.ReadLine());

            var price = 0.00;

            var isYoungstersCategory = 0 <= ageInput && ageInput <= 18;
            var isAdultsCategory = 18 < ageInput && ageInput <= 64;
            var isEldersCategory = 64 < ageInput && ageInput <= 122;

            switch (dayInput)
            {
                case "weekday":
                    if (isYoungstersCategory || isEldersCategory) { price = 12; }
                    else if (isAdultsCategory) { price = 18; }
                    break;

                case "weekend":
                    if (isYoungstersCategory || isEldersCategory) { price = 15; }
                    else if (isAdultsCategory) { price = 20; }
                    break;

                case "holiday":
                    if (isYoungstersCategory) { price = 5; }
                    else if (isAdultsCategory) { price = 12; }
                    else if (isEldersCategory) { price = 10; }
                    break;
            }

            var result = price > 0 ? $"{price}$" : "Error!";

            Console.WriteLine(result);
        }
    }
}