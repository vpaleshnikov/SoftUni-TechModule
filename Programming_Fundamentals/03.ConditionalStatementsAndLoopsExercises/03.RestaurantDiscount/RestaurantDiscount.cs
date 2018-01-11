using System;

namespace _03.RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine().ToLower();

            var hall = String.Empty;
            var price = 0.00;

            if (groupSize > 0 && groupSize <= 50)
            {
                hall = "Small Hall";
                price = 2500;
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hall = "Terrace";
                price = 5000;
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hall = "Great Hall";
                price = 7500;
            }
            else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            
            var packagePrice = 0.00;
            var discount = 0.00;

            if (package == "normal")
            {
                packagePrice = 500;
                discount = 0.05;
            }
            else if (package == "gold")
            {
                packagePrice = 750;
                discount = 0.10;
            }
            else if (package == "platinum")
            {
                packagePrice = 1000;
                discount = 0.15;
            }

            var totalPrice = price + packagePrice;
            var discountedPrice = totalPrice - (totalPrice * discount);
            var pricePerPerson = discountedPrice / groupSize;

            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
        }
    }
}
