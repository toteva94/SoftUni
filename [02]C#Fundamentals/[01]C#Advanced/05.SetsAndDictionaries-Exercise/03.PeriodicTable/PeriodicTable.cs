namespace _03.PeriodicTable
{
    using System;
    using System.Collections.Generic;
    public class PeriodicTable
    {
        public static void Main()
        {
            var chemicalElements = new SortedSet<string>();

            var count = int.Parse(Console.ReadLine());

            for (var i = 0; i < count; i++)
            {
                var currentElements = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var currentElement in currentElements)
                {
                    chemicalElements.Add(currentElement);
                }
            }

            Console.WriteLine(string.Join(" ", chemicalElements));
        }
    }
}