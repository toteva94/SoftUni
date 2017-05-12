namespace _06.InsertionSortUsingList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class InsertionSortUsingList
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var result = new List<int>();

            numbers.Add(int.MaxValue);

            for (int numbersIndex = 0; numbersIndex < numbers.Count - 1; numbersIndex++)
            {
                var inserted = false;
                var CurrentNumInNumbers = numbers[numbersIndex];

                for (int resultIndex = 0; resultIndex < result.Count; resultIndex++)
                {
                    var currentNumInResult = result[resultIndex];

                    if (CurrentNumInNumbers <= currentNumInResult)
                    {
                        inserted = true;
                        result.Insert(Math.Max(0, resultIndex), CurrentNumInNumbers);
                        break;
                    }
                }

                if (!inserted)
                {
                    result.Add(CurrentNumInNumbers);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
