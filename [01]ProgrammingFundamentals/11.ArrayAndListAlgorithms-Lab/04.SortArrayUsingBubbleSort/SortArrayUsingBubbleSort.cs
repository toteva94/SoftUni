namespace _04.SortArrayUsingBubbleSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortArrayUsingBubbleSort
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var swapped = true;
            do
            {
                swapped = false;

                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    var current = numbers[i];
                    var next = numbers[i + 1];

                    if (current > next)
                    {
                        numbers[i + 1] = current;
                        numbers[i] = next;

                        swapped = true;
                    }
                }
            } while (swapped);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
