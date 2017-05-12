namespace _03.ReverseArrayIn_place
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count/2; i++)
            {
                var leftIndex = i;
                var rightIndex = numbers.Count - 1 - i;
                

                var temp = numbers[leftIndex];
                numbers[leftIndex] = numbers[rightIndex];
                numbers[rightIndex] = temp;
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
