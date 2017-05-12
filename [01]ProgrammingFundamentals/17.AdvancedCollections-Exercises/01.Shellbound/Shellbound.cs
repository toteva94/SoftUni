namespace _01.Shellbound
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Shellbound
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var crabsShellsData = new Dictionary<string, HashSet<long>>();

            while(input != "Aggregate")
            {
                var elements = input.Split();
                var region = elements[0];
                var shellSize = long.Parse(elements[1]);

                if(!crabsShellsData.ContainsKey(region))
                 crabsShellsData[region] = new HashSet<long>();
                crabsShellsData[region].Add(shellSize);

                input = Console.ReadLine();
            }

            foreach (var regionAndShells in crabsShellsData)
            {
                var printRegion = regionAndShells.Key;
                var printSizes = regionAndShells.Value;
                long average = (long)printSizes.Sum() - (long)printSizes.Average();

                Console.WriteLine($"{printRegion} -> {string.Join(", ", printSizes)} ({average})");
            }
        }
    }
}
