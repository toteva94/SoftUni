namespace _07.CountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            numbers.Sort();
            numbers.Add(int.MaxValue);
            var counter = 1;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                var currentNumber = numbers[i];
                var nextNumber = numbers[i + 1];

                if (currentNumber == nextNumber)
                    counter++;
                else
                {
                    Console.WriteLine($"{currentNumber} -> {counter}");
                    counter = 1;
                }
            }
        }
    }
}
