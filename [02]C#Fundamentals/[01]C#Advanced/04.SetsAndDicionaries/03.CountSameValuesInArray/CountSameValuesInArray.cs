using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _03.CountSameValuesInArray
{
    public class CountSameValuesInArray
    {
        public static void Main()
        {
            var values = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => double.Parse(n))
                .ToArray();


            var occurrences = new SortedDictionary<double, int>();

            foreach (var value in values)
            {
                if (!occurrences.ContainsKey(value))
                {
                    occurrences[value] = 0;
                }

                occurrences[value]++;
            }

            foreach (var kvpOccurrence in occurrences)
            {
                Console.WriteLine($"{kvpOccurrence.Key} - {kvpOccurrence.Value} times");
            }
        }
    }
}