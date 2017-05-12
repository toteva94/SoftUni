namespace _02.SmallestElementInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SmallestElementInArray
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers.Add(int.MaxValue);
            var minNum = int.MaxValue;

            for (int i = 0; i < numbers.Count-1; i++)
            {
                var currentNum = numbers[i];

                if (currentNum < minNum)
                    minNum = currentNum;
            }

            Console.WriteLine(minNum);
        }
    }
}
