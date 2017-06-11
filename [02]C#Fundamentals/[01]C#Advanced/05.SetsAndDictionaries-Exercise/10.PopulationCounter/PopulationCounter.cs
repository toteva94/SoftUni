namespace _10.PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Runtime.InteropServices.ComTypes;
    public class PopulationCounter
    {
        public static void Main()
        {
            var populationData = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                var input = Console.ReadLine().Split(new[] { '|' });

                if (input[0] == "report")
                {
                    break;
                }

                var currentCity = input[0];
                var currentCountry = input[1];
                var currentCityPopulation = long.Parse(input[2]);

                if (!populationData.ContainsKey(currentCountry))
                {
                    populationData[currentCountry] = new Dictionary<string, long>();
                }

                if (!populationData[currentCountry].ContainsKey(currentCity))
                {
                    populationData[currentCountry][currentCity] = 0;
                }

                populationData[currentCountry][currentCity] = currentCityPopulation;
            }
               

            foreach (var countryCityAndPopulation in populationData.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                var country = countryCityAndPopulation.Key;

                Console.WriteLine($"{country} (total population: {countryCityAndPopulation.Value.Values.Sum()})");
                foreach (var cityAndPopulation in countryCityAndPopulation.Value.OrderByDescending(x => x.Value))
                {
                    var city = cityAndPopulation.Key;
                    var population = cityAndPopulation.Value;

                    Console.WriteLine($"=>{city}: {population}");
                }
            }
        }
    }
}