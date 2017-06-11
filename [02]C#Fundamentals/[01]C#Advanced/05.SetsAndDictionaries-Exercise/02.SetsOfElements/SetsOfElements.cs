namespace _02.SetsOfElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    public class SetsOfElements
    {
        public static void Main()
        {
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            var setsCount = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var firstSetCount = setsCount[0];
            var secondSetCount = setsCount[1];

            for (var i = 0; i < firstSetCount; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                firstSet.Add(currentNumber);
            }

            for (var i = 0; i < secondSetCount; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                secondSet.Add(currentNumber);
            }

            var intersectedSet = new HashSet<int>(firstSet.Intersect(secondSet));

            Console.WriteLine(string.Join(" ",intersectedSet));
        }
    }
}