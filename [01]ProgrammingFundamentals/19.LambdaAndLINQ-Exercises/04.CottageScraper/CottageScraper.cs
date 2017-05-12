namespace _04.CottageScraper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CottageScraper
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var treesData = new Dictionary<string, List<double>>();

            while (input != "chop chop")
            {
                var elements = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var treeType = elements[0];
                var treeHeight = long.Parse(elements[1]);

                if (!treesData.ContainsKey(treeType))
                    treesData[treeType] = new List<double>();
                treesData[treeType].Add(treeHeight);

                input = Console.ReadLine();
            }

            var treeToUse = Console.ReadLine();
            var minHeight = double.Parse(Console.ReadLine());

            var pricePerMeter = Math.Round(treesData.SelectMany(x => x.Value).Sum() / (double)treesData.SelectMany(x => x.Value).Count(), 2);

            var usedLogs = treesData
                .Where(x => x.Key == treeToUse)
                .SelectMany(x => x.Value)
                .Where(x => x >= minHeight)
                .Sum();

            var usedLogsPrice = Math.Round(usedLogs * pricePerMeter, 2);

            var unusedLogs = treesData
                .Where(x => x.Key != treeToUse)
                .SelectMany(x => x.Value)
                .Sum();

            var smallerThanMinHeightTrees = treesData
                .Where(x => x.Key == treeToUse)
                .SelectMany(x => x.Value)
                .Where(x => x < minHeight)
                .Sum();

            var unusedLogsPrice = Math.Round(((smallerThanMinHeightTrees + unusedLogs) * 0.25 * pricePerMeter),2);

            var totalSum = usedLogsPrice + unusedLogsPrice;

            Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");
            Console.WriteLine($"Used logs price: ${usedLogsPrice:f2}");
            Console.WriteLine($"Unused logs price: ${unusedLogsPrice:f2}");
            Console.WriteLine($"CottageScraper subtotal: ${totalSum:f2}");

        }
    }
}
