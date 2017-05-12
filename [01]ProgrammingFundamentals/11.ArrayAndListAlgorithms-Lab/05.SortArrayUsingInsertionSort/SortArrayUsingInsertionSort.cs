namespace _05.SortArrayUsingInsertionSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortArrayUsingInsertionSort
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                var j = i + 1;

                while (j > 0)
                {
                    if (numbers[j] > numbers[j - 1])
                    {
                        var temp = numbers[j];
                        numbers[j] = numbers[j - 1];
                        numbers[j - 1] = temp;
                    }

                    j--;
                }
            }

            numbers.Reverse();

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
