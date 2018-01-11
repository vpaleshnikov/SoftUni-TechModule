using System;

namespace _07.TrainingHallEquipment
{
    class TrainingHallEquipment
    {
        static void Main()
        {
            var buget = double.Parse(Console.ReadLine());
            var numberOfItems = int.Parse(Console.ReadLine());

            var total = 0.00;
            
            for (int i = 1; i <= numberOfItems; i++)
            {
                var itemName = Console.ReadLine();
                var itemPrice = double.Parse(Console.ReadLine());
                var itemCount = int.Parse(Console.ReadLine());
                if (itemCount > 1)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }
                total = total + (itemPrice * itemCount);
            }
            Console.WriteLine($"Subtotal: ${total:F2}");
            if (buget >= total)
            {
                Console.WriteLine("Money left: ${0:F2}",Math.Abs(buget - total));
            }
            else
            {
                Console.WriteLine("Not enough. We need ${0:F2} more.",Math.Abs(buget - total));
            }

        }
    }
}
