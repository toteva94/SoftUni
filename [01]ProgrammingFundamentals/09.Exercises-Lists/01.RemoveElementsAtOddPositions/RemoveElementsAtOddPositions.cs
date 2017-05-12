namespace _01.RemoveElementsAtOddPositions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveElementsAtOddPositions
    {
        public static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToList();

            var result = new List<string>();

            for (int i = 1; i < words.Count; i++)
            {
                if((i + 1) % 2 == 0)
                {
                    result.Add(words[i]);
                }
            }

            Console.WriteLine(string.Join("",result));
        }
    }
}
