namespace _07.LargestNElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LargestNElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var totalNums = int.Parse(Console.ReadLine());

            numbers.Sort();
            numbers.Reverse();

            var maxNums = numbers.Take(totalNums);

            Console.WriteLine(string.Join(" ",maxNums));
        }
    }
}
