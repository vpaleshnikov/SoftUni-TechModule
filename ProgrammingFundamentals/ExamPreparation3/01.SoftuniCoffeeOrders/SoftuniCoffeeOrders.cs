using System;
using System.Globalization;

namespace _01.SoftuniCoffeeOrders
{
    class SoftuniCoffeeOrders
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            decimal totalPrice = 0;

            for (int i = 0; i < n; i++)
            {
                decimal price = CalculatePrice();

                totalPrice += price;
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }

        public static decimal CalculatePrice()
        {

            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            var dateStr = Console.ReadLine();
            DateTime orderDate = DateTime.ParseExact(dateStr, "d/M/yyyy", CultureInfo.InvariantCulture);
            var capsulesCount = long.Parse(Console.ReadLine());

            decimal days = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

            decimal price = (days * capsulesCount) * pricePerCapsule;

            Console.WriteLine($"The price for the coffee is: ${price:F2}");

            return price;
        }
    }
}
