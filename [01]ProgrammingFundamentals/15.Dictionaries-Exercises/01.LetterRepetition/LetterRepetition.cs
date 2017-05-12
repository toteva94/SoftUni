namespace _01.LetterRepetition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class LetterRepetition
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var chars = input.ToCharArray();
            var counts = new Dictionary<char, int>();

            foreach (var character in chars)
            {
                if (counts.ContainsKey(character))
                    counts[character]++;
                else
                    counts[character] = 1;
            }

            foreach (var character in counts.Keys)
            {
                Console.WriteLine($"{character} -> {counts[character]}");
            }
        }
    }
}
