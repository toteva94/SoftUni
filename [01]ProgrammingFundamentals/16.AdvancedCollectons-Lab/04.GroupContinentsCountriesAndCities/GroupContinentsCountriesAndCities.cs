namespace _04.GroupContinentsCountriesAndCities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GroupContinentsCountriesAndCities
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var continentsData = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var continent = input[0];
                var country = input[1];
                var city = input[2];

                if (!continentsData.ContainsKey(continent))
                    continentsData[continent] = new SortedDictionary<string, SortedSet<string>>();
                if (!continentsData[continent].ContainsKey(country))
                    continentsData[continent][country] = new SortedSet<string>();
                continentsData[continent][country].Add(city);

            }

            foreach (var continentCountries in continentsData)
            {
                var continentName = continentCountries.Key;
                var countries = continentCountries.Value;

                Console.WriteLine($"{continentName}:");
                foreach (var countryCities in countries)
                {
                    var countryName = countryCities.Key;
                    var cities = countryCities.Value;
                    Console.WriteLine("  {0} -> {1}",
                      countryName, string.Join(", ", cities));
                }
            }
        }
    }
}
