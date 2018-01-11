using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SalesReport
{
    public class Sale
    {
        public string Town { get; set; }

        public string Product { get; set; }

        public double Price { get; set; }

        public double Quantity { get; set; }

    }
    class SalesReport
    {
        static void Main(string[] args)
        {
            var sales = new List<Sale>();

            sales = ReadSales();

            var salesByTown = new SortedDictionary<string, double>();

            for (int i = 0; i < sales.Count; i++)
            {
                if (!salesByTown.ContainsKey(sales[i].Town))
                {
                    salesByTown.Add(sales[i].Town, sales[i].Price * sales[i].Quantity);
                }
                else
                {
                    salesByTown[sales[i].Town] += sales[i].Price * sales[i].Quantity;
                }
            }

            foreach (var sale in salesByTown)
            {
                Console.WriteLine($"{sale.Key} -> {sale.Value:F2}");
            }

        }

        public static List<Sale> ReadSales()
        {
            var n = int.Parse(Console.ReadLine());

            var sale = new List<Sale>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToList();

                var sales = new Sale
                {
                    Town = input[0],
                    Product = input[1],
                    Price = double.Parse(input[2]),
                    Quantity = double.Parse(input[3])
                };
                sale.Add(sales);
            }
            return sale;
        }
    }
}
