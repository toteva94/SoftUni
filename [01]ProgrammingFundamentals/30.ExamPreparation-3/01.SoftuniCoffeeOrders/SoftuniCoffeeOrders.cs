namespace _01.SoftuniCoffeeOrders
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class SoftuniCoffeeOrders
    {
        public static void Main()
        {
            var ordersCount = int.Parse(Console.ReadLine());

            var orders = new List<decimal>();

            for (int i = 0; i < ordersCount; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsulesCount = long.Parse(Console.ReadLine());
                var daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                var currentOrderPrice = (daysInMonth * capsulesCount) * pricePerCapsule;
                orders.Add(currentOrderPrice);
            }

            foreach (var order in orders)
            {
                Console.WriteLine($"The price for the coffee is: ${order:f2}");
            }

            Console.WriteLine($"Total: ${orders.Sum():f2}");
        }
    }
}
