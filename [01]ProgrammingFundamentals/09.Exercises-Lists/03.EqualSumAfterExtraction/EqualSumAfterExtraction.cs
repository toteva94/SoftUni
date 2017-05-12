namespace _03.EqualSumAfterExtraction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EqualSumAfterExtraction
    {
        public static void Main()
        {
            var list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            var list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            foreach (var number in list1)
            {
                if (list2.Contains(number))
                    list2.Remove(number);
            }

            var sumList1 = list1.Sum();
            var sumList2 = list2.Sum();

            if(sumList1 == sumList2)
                Console.WriteLine($"Yes. Sum: {sumList1}");
            else
            {
                var maxSum = Math.Max(sumList1, sumList2);
                var minSum = Math.Min(sumList1, sumList2);
                var diff = maxSum - minSum;
                Console.WriteLine($"No. Diff: {diff}");
            }
               
        }
    }
}
