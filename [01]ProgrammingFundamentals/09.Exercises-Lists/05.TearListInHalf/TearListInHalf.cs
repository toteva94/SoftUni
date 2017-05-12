namespace _05.TearListInHalf
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TearListInHalf
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var list1 = new List<int>();
            var list2 = new List<int>();

            for (int i = 0; i < input.Count / 2; i++)
            {
                list1.Add(input[i]);
            }

            for (int i = input.Count / 2; i < input.Count; i++)
            {
                list2.Add(input[i]);
            }

            var result = new List<int>();

            for (int i = 0; i < list1.Count; i++)
            {
                result.Add(list2[i] / 10);
                result.Add(list1[i]);
                result.Add(list2[i] % 10);
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
