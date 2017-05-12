namespace _02.AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppendLists
    {
        public static void Main()
        {

            var input = Console.ReadLine().Split('|').ToList();

            input.Reverse();

            var result = new List<string>();

            foreach (var number in input)
            {
                var numbers = number.Split(' ').ToList();
                foreach (var num in numbers)
                {
                    if (num != "")
                        result.Add(num);
                }

            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
