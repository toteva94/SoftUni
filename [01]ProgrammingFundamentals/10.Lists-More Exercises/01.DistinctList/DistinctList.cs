namespace _01.DistinctList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DistinctList
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var result = numbers.Distinct().ToList();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
