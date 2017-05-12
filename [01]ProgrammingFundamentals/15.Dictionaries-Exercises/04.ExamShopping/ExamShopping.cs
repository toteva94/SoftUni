namespace _04.ExamShopping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ExamShopping
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var productsStorage = new Dictionary<string, int>();
     
            while (input != "shopping time")
            {
                var elements = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var product = elements[1];
                var quantity = int.Parse(elements[2]);


                if (!productsStorage.ContainsKey(product))
                    productsStorage.Add(product, 0);

                productsStorage[product] += quantity;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while(input != "exam time")
            {
                var elements = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var product = elements[1];
                var quantity = int.Parse(elements[2]);

                if (productsStorage.ContainsKey(product))
                {
                    if (productsStorage[product] <= 0)
                        Console.WriteLine($"{product} out of stock");
                    else if (quantity > productsStorage[product])
                        productsStorage[product] = 0;
                    else
                        productsStorage[product] -= quantity;
                }
                else
                {
                    Console.WriteLine($"{product} doesn't exist");
                }

                input = Console.ReadLine();
            }

            foreach (var product in productsStorage.Keys)
            {
                if (productsStorage[product] > 0)
                {
                    Console.WriteLine($"{product} -> {productsStorage[product]}");
                }
            }
        }
    }
}
