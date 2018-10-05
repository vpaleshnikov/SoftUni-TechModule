using System;

namespace _03.RestaurantDiscount
{
    public class RestaurantDiscount
    {
        public static void Main()
        {
            var groupSizeInput = int.Parse(Console.ReadLine());
            var packageInput = Console.ReadLine().ToLower();

            var hall = String.Empty;
            var price = 0.00;

            var isSmallHall = groupSizeInput > 0 && groupSizeInput <= 50;
            var isTerrace = groupSizeInput > 50 && groupSizeInput <= 100;
            var isGreatHall = groupSizeInput > 100 && groupSizeInput <= 120;
            var isInvalidHall = groupSizeInput > 120;

            if (isSmallHall) { hall = "Small Hall"; price = 2500; }

            else if (isTerrace) { hall = "Terrace"; price = 5000; }

            else if (isGreatHall) { hall = "Great Hall"; price = 7500; }

            else if (isInvalidHall) { Console.WriteLine("We do not have an appropriate hall."); return; }

            var packagePrice = 0.00;
            var discount = 0.00;

            var isNormalPackage = packageInput == "normal";
            var isGoldPackage = packageInput == "gold";
            var isPlatinumPackage = packageInput == "platinum";

            if (isNormalPackage) { packagePrice = 500; discount = 0.05; }

            else if (isGoldPackage) { packagePrice = 750; discount = 0.10; }

            else if (isPlatinumPackage) { packagePrice = 1000; discount = 0.15; }

            var totalPriceBeforeDiscount = price + packagePrice;
            var discountedPrice = totalPriceBeforeDiscount - (totalPriceBeforeDiscount * discount);
            var pricePerPerson = discountedPrice / groupSizeInput;

            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
        }
    }
}