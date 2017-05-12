namespace _04.FlipListSides
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FlipListSides
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 1; i < numbers.Count / 2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Count - i - 1];
                numbers[numbers.Count - i - 1] = temp;
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
