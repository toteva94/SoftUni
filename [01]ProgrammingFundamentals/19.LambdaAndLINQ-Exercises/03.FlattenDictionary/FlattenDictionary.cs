namespace _03.FlattenDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FlattenDictionary
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var mainDictionary = new Dictionary<string, Dictionary<string, string>>();

            while (input != "end")
            {
                var elements = input.Split().ToArray();
                if (elements[0] != "flatten")
                {

                    var mainKey = elements[0];
                    var innerKey = elements[1];
                    var innerValue = elements[2];

                    if (!mainDictionary.ContainsKey(mainKey))
                    {
                        mainDictionary[mainKey] = new Dictionary<string, string>();
                    }

                    mainDictionary[mainKey][innerKey] = innerValue;
                }
                else
                {
                    var mainKey = elements[1];
                    mainDictionary[mainKey] = mainDictionary[mainKey]
                        .ToDictionary(x => x.Key + x.Value, x => "flattened");
                }

                input = Console.ReadLine();
            }

            var orderedDictionary = mainDictionary
                .OrderByDescending(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var entry in orderedDictionary)
            {
                Console.WriteLine($"{entry.Key}");

                var orderedInnerDictionary = entry.Value
                    .Where(x => x.Value != "flattened")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                var flattenedValues = entry.Value
                    .Where(x => x.Value == "flattened")
                    .ToDictionary(x => x.Key, x => x.Value);

                var counter = 1;

                foreach (var innerEntry in orderedInnerDictionary)
                {
                    Console.WriteLine($"{counter}. {innerEntry.Key} - {innerEntry.Value}");
                    counter++;
                }

                foreach (var flattenedEntry in flattenedValues)
                {
                    Console.WriteLine($"{counter}. {flattenedEntry.Key}");
                    counter++;
                }
            }


        }
    }
}
