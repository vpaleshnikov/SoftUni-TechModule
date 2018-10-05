using System;

namespace _04.Hotel
{
    public class Hotel
    {
        public static void Main()
        {
            var month = Console.ReadLine();
            var nightsCount = int.Parse(Console.ReadLine());

            var studioPricePerNight = 0.00;
            var doubleRoomPricePerNight = 0.00;
            var masterSuitePricePerNight = 0.00;

            var isMayOrOctober = month == "May" || month == "October";
            var isJuneOrSeptember = month == "June" || month == "September";
            var isJulyOrAugustOrSeptember = month == "July" || month == "August" || month == "December";

            if (isMayOrOctober)
            {
                studioPricePerNight = 50;
                doubleRoomPricePerNight = 65;
                masterSuitePricePerNight = 75;

                if (nightsCount > 7) { studioPricePerNight -= studioPricePerNight * 0.05; }
            }
            else if (isJuneOrSeptember)
            {
                studioPricePerNight = 60;
                doubleRoomPricePerNight = 72;
                masterSuitePricePerNight = 82;
                if (nightsCount > 14) { doubleRoomPricePerNight -= doubleRoomPricePerNight * 0.10; }
            }
            else if (isJulyOrAugustOrSeptember)
            {
                studioPricePerNight = 68;
                doubleRoomPricePerNight = 77;
                masterSuitePricePerNight = 89;
                if (nightsCount > 14) { masterSuitePricePerNight -= masterSuitePricePerNight * 0.15; }
            }

            var totalPriceStudio = studioPricePerNight * nightsCount;
            var totalPriceDouble = doubleRoomPricePerNight * nightsCount;
            var totalPriceSuite = masterSuitePricePerNight * nightsCount;

            if (nightsCount > 7 && month == "September" || nightsCount > 7 && month == "October")
            {
                totalPriceStudio = studioPricePerNight * (nightsCount - 1);
            }

            Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.");
            Console.WriteLine($"Double: {totalPriceDouble:F2} lv.");
            Console.WriteLine($"Suite: {totalPriceSuite:F2} lv.");
        }
    }
}