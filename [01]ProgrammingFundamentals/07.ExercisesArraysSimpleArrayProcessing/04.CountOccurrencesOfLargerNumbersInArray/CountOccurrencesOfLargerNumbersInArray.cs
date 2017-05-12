namespace _4.CountOccurrencesOfLargerNumbersInArray
{
    using System;
    using System.Linq;

    public class CountOccurrencesOfLargerNumbersInArray
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var p = double.Parse(Console.ReadLine());

            var count = 0;

            foreach (var num in numbers)
            {
                if (num > p)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
