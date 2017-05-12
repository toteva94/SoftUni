namespace _02.DefaultValues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class DefaultValues
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var data = new Dictionary<string, string>();

            while (input != "end")
            {
                var elements = input
                    .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var currentKey = elements[0];
                var currentValue = elements[1];

                data[currentKey] = currentValue;

                input = Console.ReadLine();
            }

            var defaultValue = Console.ReadLine();

            var unchangedValues = data
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            var changedValues = data
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => defaultValue);

            foreach (var pair in unchangedValues)
            {
                Console.WriteLine($"{pair.Key} <-> {pair.Value}");
            }

            foreach (var pair in changedValues)
            {
                Console.WriteLine($"{pair.Key} <-> {pair.Value}");
            }
               
        }
    }
}
