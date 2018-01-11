using System;

namespace _04.Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            var studioPricePerNight = 0.00;
            var doublePricePerNight = 0.00;
            var suitePricePerNight = 0.00;


            if (month == "May"
                || month == "October")
            {
                studioPricePerNight = 50;
                doublePricePerNight = 65;
                suitePricePerNight = 75;
                if (nights > 7)
                {
                    studioPricePerNight -= studioPricePerNight * 0.05;
                }
            }
            else if (month == "June"
                || month == "September")
            {
                studioPricePerNight = 60;
                doublePricePerNight = 72;
                suitePricePerNight = 82;
                if (nights > 14)
                {
                    doublePricePerNight -= doublePricePerNight * 0.10;
                }
            }
            else if (month == "July"
                || month == "August"
                || month == "December")
            {
                studioPricePerNight = 68;
                doublePricePerNight = 77;
                suitePricePerNight = 89;
                if (nights > 14)
                {
                    suitePricePerNight -= suitePricePerNight * 0.15;
                }
            }
            var totalPriceStudio = 0.00;
            var totalPriceDouble = 0.00;
            var totalPriceSuite = 0.00;
            if (nights > 7 && month == "September"
                || nights > 7 && month == "October")
            {
                totalPriceStudio = studioPricePerNight * (nights - 1);
            }
            else
            {
                totalPriceStudio = studioPricePerNight * nights;
            }
            totalPriceDouble = doublePricePerNight * nights;
            totalPriceSuite = suitePricePerNight * nights;


            Console.WriteLine($"Studio: { totalPriceStudio:F2} lv.");
            Console.WriteLine($"Double: { totalPriceDouble:F2} lv.");
            Console.WriteLine($"Suite: {totalPriceSuite:F2} lv.");
        }
    }
}
