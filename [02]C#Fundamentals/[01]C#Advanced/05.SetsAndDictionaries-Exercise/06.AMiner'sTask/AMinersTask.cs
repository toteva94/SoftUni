namespace _06.AMiner_sTask
{
    using System;
    using System.Collections.Generic;
    public class AMinersTask
    {
        public static void Main()
        {
            var resourcesData = new Dictionary<string,int>();

            while (true)
            {
                var resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }

                var quantity = int.Parse(Console.ReadLine());

                if (!resourcesData.ContainsKey(resource))
                {
                    resourcesData[resource] = 0;
                }

                resourcesData[resource] += quantity;
            }

            foreach (var resourceAndQuantity in resourcesData)
            {
                Console.WriteLine($"{resourceAndQuantity.Key} -> {resourceAndQuantity.Value}");
            }
        }
    }
}