namespace _07.SalesReport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SalesReport
    {
        public class Sale
        {
            public string Town { get; set; }

            public string Product { get; set; }

            public decimal Price { get; set; }

            public decimal Quantity { get; set; }

            public decimal TotalSales
            {
                get
                {
                    return Price * Quantity;
                }
            }
        }
       public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var salesByTown = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var sale = ReadSale();

                if (!salesByTown.ContainsKey(sale.Town))
                    salesByTown[sale.Town] = 0;
                salesByTown[sale.Town] += sale.TotalSales;
            }

            foreach (var town in salesByTown.Keys)
            {
                Console.WriteLine($"{town} -> {salesByTown[town]:f2}");
            }
        }

        public static Sale ReadSale()
        {
            var input = Console.ReadLine()
                  .Split()
                  .ToArray();

            return new Sale
            {
                Town = input[0],
                Product = input[1],
                Price = decimal.Parse(input[2]),
                Quantity = decimal.Parse(input[3])
            };
        }
    }
}
