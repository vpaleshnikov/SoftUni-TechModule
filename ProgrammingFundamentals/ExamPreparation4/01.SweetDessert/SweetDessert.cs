using System;

namespace _01.SweetDessert
{
    class SweetDessert
    {
        static void Main(string[] args)
        {
            var cash = double.Parse(Console.ReadLine());
            var guests = double.Parse(Console.ReadLine());
            var bananasPrice = double.Parse(Console.ReadLine()) * 2;
            var eggsPrice = double.Parse(Console.ReadLine()) * 4;
            var berriesPrice = double.Parse(Console.ReadLine()) * 0.2;
            
            var money = Math.Ceiling(guests / 6) * (bananasPrice + eggsPrice + berriesPrice);

            if (money <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {money:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(money - cash):F2}lv more.");
            }
        }
    }
}
