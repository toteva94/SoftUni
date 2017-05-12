namespace _01.MinMaxSumAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MinMaxSumAverage
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            var sum = numbers.Sum();
            var min = numbers.Min();
            var max = numbers.Max();
            var average = numbers.Average();

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
