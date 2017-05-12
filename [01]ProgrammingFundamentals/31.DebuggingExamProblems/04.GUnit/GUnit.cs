namespace _04.GUnit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class GUnit
    {
        public static void Main()
        {
            var validationRegex = new Regex(@"^([A-Z][a-zA-z0-9]+) \| ([A-Z][a-zA-z0-9]+) \| ([A-Z][a-zA-z0-9]+)$");

            var classesData = new Dictionary<string, Dictionary<string, List<string>>>();

            var input = Console.ReadLine();

            while (input != "It's testing time!")
            {
                if (validationRegex.IsMatch(input))
                {
                    var match = validationRegex.Match(input);

                    var className = match.Groups[1].Value;
                    var methodName = match.Groups[2].Value;
                    var unitTest = match.Groups[3].Value;

                    if (className.Length < 2 || methodName.Length < 2 || unitTest.Length < 2)
                    {
                        break;
                    }
                    else
                    {
                        if (!classesData.ContainsKey(className))
                        {
                            classesData[className] = new Dictionary<string, List<string>>();
                        }

                        if (!classesData[className].ContainsKey(methodName))
                        {
                            classesData[className][methodName] = new List<string>();
                        }

                        if (!classesData[className][methodName].Contains(unitTest))
                        {
                            classesData[className][methodName].Add(unitTest);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            var sortedClassesData = classesData
                .OrderByDescending(x => x.Value.Values.Sum(y => y.Count))
                .ThenBy(x => x.Value.Count)
                .ThenBy(x => x.Key, StringComparer.Ordinal)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedClassesData)
            {
                var className = kvp.Key;

                Console.WriteLine($"{className}:");

                var sortedMethods = kvp.Value
                    .OrderByDescending(m => m.Value.Count)
                    .ThenBy(m => m.Key, StringComparer.Ordinal)
                    .ToDictionary(m => m.Key, m => m.Value);

                foreach (var method in sortedMethods)
                {
                    var methodName = method.Key;

                    Console.WriteLine($"##{methodName}");

                    var sortedUnitTests = method.Value.OrderBy(u => u.Length)
                        .ThenBy(u => u, StringComparer.Ordinal)
                        .ToList();

                    foreach (var test in sortedUnitTests)
                    {
                        Console.WriteLine($"####{test}");
                    }
                }
            }
        }
    }
}
